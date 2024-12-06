using System.Collections.Generic;
using System;

namespace family_tree.Models
{
    public class Person
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public List<string> Parents { get; set; } = new List<string>();
        public List<string> Children { get; set; } = new List<string>();
        public string Spouse { get; set; }
    }
}