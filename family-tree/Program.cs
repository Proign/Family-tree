using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using family_tree.Forms;
using family_tree.Dal;
using family_tree.Bll;

namespace family_tree
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string dataFilePath = "Data/familyTree.json";
            var familyTreeStorage = new JsonFileStorage(dataFilePath);
            var persons = familyTreeStorage.LoadFamilyTree();
            var familyTreeManager = new FamilyTreeManager(persons);
            var searchManager = new SearchManager(persons);

            Task.Run(() =>
            {
                MessageBox.Show($"Загружено {familyTreeManager.GetAllPersons().Count} человек(а).", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(familyTreeStorage, familyTreeManager, searchManager, dataFilePath));
        }
    }
}