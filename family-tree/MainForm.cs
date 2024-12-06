using family_tree.Bll;
using family_tree.Dal;
using family_tree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace family_tree.Forms
{
    public partial class MainForm : Form
    {
        private readonly IFamilyTreeStorage _familyTreeStorage;
        private readonly IFamilyTreeManager _familyTreeManager;
        private readonly ISearchManager _searchManager;
        private readonly string _dataFilePath;
        private bool _isUpdatingComboBoxes = false;

        public MainForm(IFamilyTreeStorage familyTreeStorage, IFamilyTreeManager familyTreeManager, ISearchManager searchManager, string dataFilePath)
        {
            InitializeComponent();

            _familyTreeStorage = familyTreeStorage ?? throw new ArgumentNullException(nameof(familyTreeStorage));
            _familyTreeManager = familyTreeManager ?? throw new ArgumentNullException(nameof(familyTreeManager));
            _searchManager = searchManager ?? throw new ArgumentNullException(nameof(searchManager));
            _dataFilePath = dataFilePath ?? throw new ArgumentNullException(nameof(dataFilePath));

            AddPersonToolStripMenuItem.Click += AddPersonToolStripMenuItem_Click;
            SetRelationshipsToolStripMenuItem.Click += SetRelationshipsToolStripMenuItem_Click;
            PersonsTabPage.Enter += PersonsTabPage_Enter;
            TreeTabPage.Enter += TreeTabPage_Enter;
            FindRelativesComboBox.SelectedIndexChanged += FindRelativesComboBox_SelectedIndexChanged;
            GetAgeByPersonComboBox.SelectedIndexChanged += GetAgeByPersonComboBox_SelectedIndexChanged;
            FirstPersonAncestorsComboBox.SelectedIndexChanged += FirstPersonAncestorsComboBox_SelectedIndexChanged;
            SecondPersonAncestorsComboBox.SelectedIndexChanged += SecondPersonAncestorsComboBox_SelectedIndexChanged;
            ClearJsonToolStripMenuItem.Click += ClearJsonToolStripMenuItem_Click;

            personsDataGridView.AllowUserToAddRows = false;
            familyTreeTextBox.Multiline = true;
            familyTreeTextBox.ScrollBars = ScrollBars.Vertical;

            UpdateFindRelativesComboBox();
            UpdateGetAgeByPersonComboBox();
            UpdateFirstPersonAncestorsComboBox();
            UpdateSecondPersonAncestorsComboBox();
        }

        private void UpdateFindRelativesComboBox()
        {
            FindRelativesComboBox.DataSource = null;
            FindRelativesComboBox.DataSource = _familyTreeManager.GetAllPersons();
            FindRelativesComboBox.DisplayMember = "FullName";
            FindRelativesComboBox.ValueMember = "ID";
            FindRelativesComboBox.SelectedIndex = -1;
        }

        private void UpdateGetAgeByPersonComboBox()
        {
            GetAgeByPersonComboBox.DataSource = null;
            GetAgeByPersonComboBox.DataSource = _searchManager.GetPersonsWithChildren();
            GetAgeByPersonComboBox.DisplayMember = "FullName";
            GetAgeByPersonComboBox.ValueMember = "ID";
            GetAgeByPersonComboBox.SelectedIndex = -1;
        }

        private void UpdateFirstPersonAncestorsComboBox()
        {
            _isUpdatingComboBoxes = true;
            try
            {
                var selectedSecondPerson = SecondPersonAncestorsComboBox.SelectedItem as Person;

                var firstPersonCandidates = _searchManager.GetFilteredPersons(selectedSecondPerson);

                var selectedFirstPerson = FirstPersonAncestorsComboBox.SelectedItem as Person;

                FirstPersonAncestorsComboBox.DataSource = null;
                FirstPersonAncestorsComboBox.DataSource = firstPersonCandidates;
                FirstPersonAncestorsComboBox.DisplayMember = "FullName";
                FirstPersonAncestorsComboBox.ValueMember = "ID";

                if (selectedFirstPerson != null && firstPersonCandidates.Any(p => p.ID == selectedFirstPerson.ID))
                {
                    FirstPersonAncestorsComboBox.SelectedItem = selectedFirstPerson;
                }
                else
                {
                    FirstPersonAncestorsComboBox.SelectedIndex = -1;
                }
            }
            finally
            {
                _isUpdatingComboBoxes = false;
            }
        }

        private void UpdateSecondPersonAncestorsComboBox()
        {
            _isUpdatingComboBoxes = true;
            try
            {
                var selectedFirstPerson = FirstPersonAncestorsComboBox.SelectedItem as Person;

                var secondPersonCandidates = _searchManager.GetFilteredPersons(selectedFirstPerson);

                var selectedSecondPerson = SecondPersonAncestorsComboBox.SelectedItem as Person;

                SecondPersonAncestorsComboBox.DataSource = null;
                SecondPersonAncestorsComboBox.DataSource = secondPersonCandidates;
                SecondPersonAncestorsComboBox.DisplayMember = "FullName";
                SecondPersonAncestorsComboBox.ValueMember = "ID";

                if (selectedSecondPerson != null && secondPersonCandidates.Any(p => p.ID == selectedSecondPerson.ID))
                {
                    SecondPersonAncestorsComboBox.SelectedItem = selectedSecondPerson;
                }
                else
                {
                    SecondPersonAncestorsComboBox.SelectedIndex = -1;
                }
            }
            finally
            {
                _isUpdatingComboBoxes = false;
            }
        }

        private void AddPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addPersonForm = new AddPersonForm(_familyTreeStorage, _familyTreeManager.GetAllPersons());
            addPersonForm.FormClosedEvent += RefreshData;
            addPersonForm.ShowDialog();
        }

        private void SetRelationshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relationshipForm = new RelationshipForm(_familyTreeManager, _dataFilePath);
            relationshipForm.FormClosedEvent += RefreshData;
            relationshipForm.ShowDialog();
        }

        private void PersonsTabPage_Enter(object sender, EventArgs e) => LoadPersonsDataGrid();

        private void LoadPersonsDataGrid()
        {
            personsDataGridView.Rows.Clear();
            personsDataGridView.Columns.Clear();

            personsDataGridView.Columns.Add("FullName", "ФИО");
            personsDataGridView.Columns.Add("DateOfBirth", "Дата рождения");
            personsDataGridView.Columns.Add("Gender", "Пол");
            personsDataGridView.Columns.Add("Spouse", "Супруг/супруга");

            foreach (var person in _familyTreeManager.GetAllPersons())
            {
                string spouseName = _familyTreeManager.GetSpouseFullName(person.ID);
                personsDataGridView.Rows.Add(person.FullName, person.DateOfBirth.ToString("dd.MM.yyyy"), person.Gender, string.IsNullOrEmpty(spouseName) ? "—" : spouseName);
            }
        }

        private void ShowFamilyTreeText() => familyTreeTextBox.Text = _familyTreeManager.GenerateRootPersonsTreeText();

        private void TreeTabPage_Enter(object sender, EventArgs e) => ShowFamilyTreeText();

        private void RefreshData()
        {
            ShowFamilyTreeText();
            LoadPersonsDataGrid();

            UpdateFindRelativesComboBox();
            UpdateGetAgeByPersonComboBox();

            UpdateFirstPersonAncestorsComboBox();
            UpdateSecondPersonAncestorsComboBox();
        }

        private void FindRelativesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = FindRelativesComboBox.SelectedItem as Person;

            ParentsListBox.Items.Clear();
            ChildrenListBox.Items.Clear();

            if (selectedPerson == null) return;

            var parents = _searchManager.GetParents(selectedPerson);
            if (parents.Any())
            {
                foreach (var parent in parents)
                    ParentsListBox.Items.Add(parent);
            }
            else
            {
                ParentsListBox.Items.Add("Нет доступных кандидатов");
            }

            var children = _searchManager.GetChildren(selectedPerson);
            if (children.Any())
            {
                foreach (var child in children)
                    ChildrenListBox.Items.Add(child);
            }
            else
            {
                ChildrenListBox.Items.Add("Нет доступных кандидатов");
            }
        }

        private void GetAgeByPersonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPerson = GetAgeByPersonComboBox.SelectedItem as Person;

            AgeListBox.Items.Clear();

            if (selectedPerson == null)
            {
                return;
            }

            var childrenWithAges = _searchManager.GetChildrenWithAgesAtBirth(selectedPerson);

            if (childrenWithAges.Any())
            {
                foreach (var childWithAge in childrenWithAges)
                {
                    AgeListBox.Items.Add($"{childWithAge.Key}: возраст предка - {childWithAge.Value}");
                }
            }
            else
            {
                AgeListBox.Items.Add("Нет данных о детях.");
            }
        }

        private void FirstPersonAncestorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingComboBoxes) return;

            _isUpdatingComboBoxes = true;
            try
            {
                UpdateSecondPersonAncestorsComboBox();
                UpdateCommonAncestorsList();
            }
            finally
            {
                _isUpdatingComboBoxes = false;
            }
        }

        private void SecondPersonAncestorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingComboBoxes) return;

            _isUpdatingComboBoxes = true;
            try
            {
                UpdateFirstPersonAncestorsComboBox();
                UpdateCommonAncestorsList();
            }
            finally
            {
                _isUpdatingComboBoxes = false;
            }
        }

        private void UpdateCommonAncestorsList()
        {
            var firstPerson = FirstPersonAncestorsComboBox.SelectedItem as Person;
            var secondPerson = SecondPersonAncestorsComboBox.SelectedItem as Person;

            AncestorsListBox.Items.Clear();

            if (firstPerson == null || secondPerson == null)
            {
                AncestorsListBox.Items.Add("Необходимо выбрать обоих людей");
                return;
            }

            var commonAncestors = _searchManager.GetCommonAncestors(firstPerson, secondPerson);

            if (commonAncestors.Any())
            {
                foreach (var ancestor in commonAncestors)
                {
                    AncestorsListBox.Items.Add(ancestor.FullName);
                }
            }
            else
            {
                AncestorsListBox.Items.Add("Общие предки не найдены");
            }
        }

        private void ClearJsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _familyTreeStorage.SaveFamilyTree(new List<Person>());

                _familyTreeManager.ClearData();
                _searchManager.ClearData();

                RefreshData();

                MessageBox.Show("Данные успешно удалены.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}