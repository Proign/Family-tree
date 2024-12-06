using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using family_tree.Models;

namespace family_tree.Dal
{
    public class JsonFileStorage : IFamilyTreeStorage
    {
        private readonly string _filePath;

        public JsonFileStorage(string filePath)
        {
            _filePath = filePath;
        }

        public List<Person> LoadFamilyTree()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                var data = JsonSerializer.Deserialize<Dictionary<string, List<Person>>>(json);

                return data != null && data.ContainsKey("Persons") ? data["Persons"] : new List<Person>();
            }
            return new List<Person>();
        }

        public void SaveFamilyTree(List<Person> persons)
        {
            var data = new Dictionary<string, List<Person>>()
            {
                { "Persons", persons }
            };

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}