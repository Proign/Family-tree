using family_tree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace family_tree.Bll
{
    public class SearchManager : ISearchManager
    {
        private readonly List<Person> _persons;

        public SearchManager(List<Person> persons)
        {
            _persons = persons ?? throw new ArgumentNullException(nameof(persons));
        }

        public List<string> GetParents(Person selectedPerson)
        {
            return _persons
                .Where(p => selectedPerson.Parents.Contains(p.ID))
                .Select(p => p.FullName)
                .ToList();
        }

        public List<string> GetChildren(Person selectedPerson)
        {
            return _persons
                .Where(p => p.Parents.Contains(selectedPerson.ID))
                .Select(p => p.FullName)
                .ToList();
        }

        public List<Person> GetPersonsWithChildren()
        {
            return _persons.Where(p => p.Children != null && p.Children.Any()).ToList();
        }

        public Dictionary<string, int> GetChildrenWithAgesAtBirth(Person selectedPerson)
        {
            return _persons
                .Where(child => child.Parents.Contains(selectedPerson.ID))
                .ToDictionary(
                    child => child.FullName,
                    child => child.DateOfBirth.Year - selectedPerson.DateOfBirth.Year
                );
        }

        public List<Person> GetCommonAncestors(Person person1, Person person2)
        {
            if (person1 == null || person2 == null)
                return new List<Person>();

            var ancestors1 = GetAncestors(person1);
            var ancestors2 = GetAncestors(person2);

            return ancestors1.Intersect(ancestors2).ToList();
        }

        public List<Person> GetFilteredPersons(Person excludedPerson)
        {
            return _persons
                .Where(p => excludedPerson == null || p.ID != excludedPerson.ID)
                .ToList();
        }

        private List<Person> GetAncestors(Person person)
        {
            var ancestors = new List<Person>();
            var parentsQueue = new Queue<Person>(_persons.Where(p => person.Parents.Contains(p.ID)));

            while (parentsQueue.Count > 0)
            {
                var current = parentsQueue.Dequeue();
                ancestors.Add(current);

                foreach (var parent in _persons.Where(p => current.Parents.Contains(p.ID)))
                {
                    parentsQueue.Enqueue(parent);
                }
            }

            return ancestors;
        }

        public void ClearData()
        {
            _persons.Clear();
        }
    }
}