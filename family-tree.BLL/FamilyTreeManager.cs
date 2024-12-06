using family_tree.Dal;
using family_tree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace family_tree.Bll
{
    public class FamilyTreeManager : IFamilyTreeManager
    {
        private List<Person> _persons;

        public FamilyTreeManager(List<Person> persons)
        {
            _persons = persons ?? new List<Person>();
        }

        public List<Person> GetAllPersons() => _persons;

        public void AddPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));
            _persons.Add(person);
        }

        public string GetSpouseFullName(string personId)
        {
            var person = _persons.FirstOrDefault(p => p.ID == personId);
            if (person == null || string.IsNullOrEmpty(person.Spouse)) return string.Empty;

            var spouse = _persons.FirstOrDefault(p => p.ID == person.Spouse);
            return spouse?.FullName ?? string.Empty;
        }

        public List<Person> GetRootPersons()
        {
            return _persons.Where(p => p.Gender == "Male" && (p.Parents == null || !p.Parents.Any())).ToList();
        }

        public string GenerateRootPersonsTreeText()
        {
            var rootPersons = GetRootPersons();
            var visitedPersons = new HashSet<string>();
            var familyTreeText = string.Empty;

            foreach (var rootPerson in rootPersons)
            {
                familyTreeText += GenerateFamilyTreeText(rootPerson, 0, visitedPersons) + Environment.NewLine;
            }

            return familyTreeText.Trim();
        }

        private string GenerateFamilyTreeText(Person person, int indentLevel, HashSet<string> visitedPersons)
        {
            if (person == null || visitedPersons.Contains(person.ID)) return string.Empty;

            visitedPersons.Add(person.ID);
            string indent = new string(' ', indentLevel * 4);
            string familyText = string.Empty;

            bool isParent = person.Children != null && person.Children.Any();
            var spouse = _persons.FirstOrDefault(p => p.ID == person.Spouse && !visitedPersons.Contains(p.ID));
            string spouseLabel = person.Gender == "Male" ? "супруга" : "супруг";
            string spouseInfo = spouse != null
                ? $" ( {spouseLabel}: {spouse.FullName} [{spouse.DateOfBirth:dd.MM.yyyy}] )"
                : "";

            string birthDateInfo = $" [{person.DateOfBirth:dd.MM.yyyy}]";
            string marker = isParent ? "*" : "-";
            familyText += $"{indent}{marker} {person.FullName} {birthDateInfo}{spouseInfo}{Environment.NewLine}";

            if (spouse != null)
            {
                visitedPersons.Add(spouse.ID);
            }

            if (isParent)
            {
                foreach (var childId in person.Children)
                {
                    var child = _persons.FirstOrDefault(p => p.ID == childId);
                    if (child != null)
                    {
                        familyText += GenerateFamilyTreeText(child, indentLevel + 1, visitedPersons);
                    }
                }
            }

            return familyText;
        }

        public List<Person> GetPossibleParents(Person person)
        {
            return _persons.Where(p =>
                p.DateOfBirth <= person.DateOfBirth.AddYears(-18)
                && p.ID != person.ID
                && !p.Children.Contains(person.ID)).ToList();
        }

        public List<Person> GetPossibleSpouses(Person person)
        {
            return _persons.Where(p =>
                p.Gender != person.Gender
                && p.DateOfBirth <= DateTime.Now.AddYears(-18)
                && p.ID != person.ID
                && p.Spouse == null).ToList();
        }

        public List<Person> GetPossibleChildren(Person person)
        {
            return _persons.Where(p =>
                p.DateOfBirth >= person.DateOfBirth.AddYears(18)
                && p.ID != person.ID
                && p.Parents.Count < 2).ToList();
        }

        public void UpdateRelationships(Person person, List<Person> parents, Person spouse, List<Person> children)
        {
            if (parents.Count == 2)
            {
                var parent1 = parents[0];
                var parent2 = parents[1];

                if (parent1.Gender == parent2.Gender)
                    throw new ArgumentException("Родители должны быть разного пола.");

                person.Parents.Clear();
                person.Parents.AddRange(parents.Select(p => p.ID));

                foreach (var parent in parents)
                {
                    if (!parent.Children.Contains(person.ID))
                        parent.Children.Add(person.ID);
                }
            }

            if (spouse != null)
            {
                person.Spouse = spouse.ID;
                spouse.Spouse = person.ID;

                foreach (var childId in person.Children)
                {
                    if (!spouse.Children.Contains(childId))
                        spouse.Children.Add(childId);
                }

                foreach (var childId in spouse.Children)
                {
                    if (!person.Children.Contains(childId))
                        person.Children.Add(childId);
                }
            }

            foreach (var child in children)
            {
                if (!person.Children.Contains(child.ID))
                    person.Children.Add(child.ID);

                if (!child.Parents.Contains(person.ID))
                    child.Parents.Add(person.ID);

                if (person.Spouse != null)
                {
                    var spousePerson = _persons.FirstOrDefault(p => p.ID == person.Spouse);
                    if (spousePerson != null)
                    {
                        if (!spousePerson.Children.Contains(child.ID))
                            spousePerson.Children.Add(child.ID);

                        if (!child.Parents.Contains(spousePerson.ID))
                            child.Parents.Add(spousePerson.ID);
                    }
                }
            }
        }

        public void SaveChanges(string filePath)
        {
            var familyTreeService = new JsonFileStorage(filePath);
            familyTreeService.SaveFamilyTree(_persons);
        }

        public void ClearData()
        {
            _persons.Clear();
        }
    }
}