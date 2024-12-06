using family_tree.Bll;
using family_tree.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace family_tree.Forms
{
    public partial class RelationshipForm : Form
    {
        private readonly IFamilyTreeManager _familyTreeManager;
        private readonly string _dataFilePath;
        public event Action FormClosedEvent;

        public RelationshipForm(IFamilyTreeManager familyTreeManager, string dataFilePath)
        {
            InitializeComponent();
            _familyTreeManager = familyTreeManager;
            _dataFilePath = dataFilePath;

            InitializeComboBox();
            this.PersonComboBox.SelectedIndexChanged += PersonComboBox_SelectedIndexChanged;
            this.FormClosing += RelationshipForm_FormClosing;
        }

        private void InitializeComboBox()
        {
            PersonComboBox.DataSource = _familyTreeManager.GetAllPersons();
            PersonComboBox.DisplayMember = "FullName";
            PersonComboBox.ValueMember = "ID";
            PersonComboBox.SelectedIndex = -1;
        }

        private void PersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = PersonComboBox.SelectedItem as Person;
            if (selectedPerson == null) return;

            UpdateParentsList(selectedPerson);
            UpdateSpousesList(selectedPerson);
            UpdateChildrenList(selectedPerson);
        }

        private void UpdateParentsList(Person selectedPerson)
        {
            ParentsCheckedListBox.Items.Clear();

            if (selectedPerson.Parents.Count >= 2)
            {
                ParentsCheckedListBox.Items.Add("У этого человека уже есть родители.");
                ParentsCheckedListBox.Enabled = false;
                return;
            }

            var possibleParents = _familyTreeManager.GetPossibleParents(selectedPerson);
            if (possibleParents.Any())
            {
                foreach (var person in possibleParents)
                    ParentsCheckedListBox.Items.Add(person.FullName, false);
            }
            else
            {
                ParentsCheckedListBox.Items.Add("Нет доступных кандидатов.");
            }

            ParentsCheckedListBox.Enabled = possibleParents.Any();
        }

        private void UpdateSpousesList(Person selectedPerson)
        {
            SpouseCheckedListBox.Items.Clear();

            if (selectedPerson.Spouse != null)
            {
                SpouseCheckedListBox.Items.Add("Супруг(а) уже добавлен(а).");
                SpouseCheckedListBox.Enabled = false;
                return;
            }

            var possibleSpouses = _familyTreeManager.GetPossibleSpouses(selectedPerson);
            if (possibleSpouses.Any())
            {
                foreach (var person in possibleSpouses)
                    SpouseCheckedListBox.Items.Add(person.FullName, false);
            }
            else
            {
                SpouseCheckedListBox.Items.Add("Нет доступных кандидатов.");
            }

            SpouseCheckedListBox.Enabled = possibleSpouses.Any();
        }

        private void UpdateChildrenList(Person selectedPerson)
        {
            ChildrenCheckedListBox.Items.Clear();

            var possibleChildren = _familyTreeManager.GetPossibleChildren(selectedPerson);
            if (possibleChildren.Any())
            {
                foreach (var person in possibleChildren)
                    ChildrenCheckedListBox.Items.Add(person.FullName, false);
            }
            else
            {
                ChildrenCheckedListBox.Items.Add("Нет доступных кандидатов.");
            }

            ChildrenCheckedListBox.Enabled = possibleChildren.Any();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            var selectedPerson = PersonComboBox.SelectedItem as Person;
            if (selectedPerson == null) return;

            var selectedParents = ParentsCheckedListBox.CheckedItems.Cast<string>()
                .Select(name => _familyTreeManager.GetAllPersons().FirstOrDefault(p => p.FullName == name))
                .Where(p => p != null)
                .ToList();

            var spouseName = SpouseCheckedListBox.CheckedItems.Cast<string>().FirstOrDefault();
            var spouse = _familyTreeManager.GetAllPersons().FirstOrDefault(p => p.FullName == spouseName);

            var selectedChildren = ChildrenCheckedListBox.CheckedItems.Cast<string>()
                .Select(name => _familyTreeManager.GetAllPersons().FirstOrDefault(p => p.FullName == name))
                .Where(p => p != null)
                .ToList();

            try
            {
                _familyTreeManager.UpdateRelationships(selectedPerson, selectedParents, spouse, selectedChildren);
                _familyTreeManager.SaveChanges(_dataFilePath);
                MessageBox.Show("Связи успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClosedEvent?.Invoke();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RelationshipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosedEvent?.Invoke();
        }
    }
}