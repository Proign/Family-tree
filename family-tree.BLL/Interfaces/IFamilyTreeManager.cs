using family_tree.Models;
using System.Collections.Generic;

namespace family_tree.Bll
{
    public interface IFamilyTreeManager
    {
        List<Person> GetAllPersons();
        void AddPerson(Person person);
        string GetSpouseFullName(string personId);
        List<Person> GetRootPersons();
        string GenerateRootPersonsTreeText();
        List<Person> GetPossibleParents(Person person);
        List<Person> GetPossibleSpouses(Person person);
        List<Person> GetPossibleChildren(Person person);
        void UpdateRelationships(Person person, List<Person> parents, Person spouse, List<Person> children);
        void SaveChanges(string filePath);
        void ClearData();
    }
}