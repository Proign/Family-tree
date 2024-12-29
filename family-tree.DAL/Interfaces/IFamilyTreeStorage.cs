using family_tree.Models;
using System;
using System.Collections.Generic;

namespace family_tree.Dal
{
    public interface IFamilyTreeStorage
    {
        List<Person> LoadFamilyTree();
        void SaveFamilyTree(List<Person> persons);
    }
}