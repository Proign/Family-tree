using family_tree.Models;
using System;
using System.Collections.Generic;

namespace family_tree.Bll
{
    public interface ISearchManager
    {
        List<string> GetParents(Person selectedPerson);
        List<string> GetChildren(Person selectedPerson);
        List<Person> GetPersonsWithChildren();
        Dictionary<string, int> GetChildrenWithAgesAtBirth(Person selectedPerson);
        List<Person> GetCommonAncestors(Person person1, Person person2);
        List<Person> GetFilteredPersons(Person excludedPerson);
        void ClearData();
    }
}