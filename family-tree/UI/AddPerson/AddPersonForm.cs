using family_tree.Bll;
using family_tree.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using family_tree.Dal;

namespace family_tree.Forms
{
    public partial class AddPersonForm : Form
    {
        private readonly IFamilyTreeStorage _jsonFileStorage;
        private readonly List<Person> _persons;

        public event Action FormClosedEvent;

        public AddPersonForm(IFamilyTreeStorage jsonFileStorage, List<Person> persons)
        {
            InitializeComponent();
            _jsonFileStorage = jsonFileStorage;
            _persons = persons;

            GenderComboBox.Items.Add("Male");
            GenderComboBox.Items.Add("Female");
            GenderComboBox.SelectedIndex = 0;
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameTextBox.Text) || BirthDateTimePicker.Value == null || GenderComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            var fullName = FullNameTextBox.Text;
            var birthDate = BirthDateTimePicker.Value;
            var gender = GenderComboBox.SelectedItem.ToString();

            var newPersonId = (_persons.Count > 0) ? (_persons.Max(p => int.Parse(p.ID)) + 1).ToString() : "1";

            var newPerson = new Person
            {
                ID = newPersonId,
                FullName = fullName,
                DateOfBirth = birthDate,
                Gender = gender,
                Children = new List<string>(),
                Spouse = null
            };

            _persons.Add(newPerson);

            _jsonFileStorage.SaveFamilyTree(_persons);

            FormClosedEvent?.Invoke();
            MessageBox.Show("Человек успешно добавлен!");
            this.Close();
        }

        private void AddPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosedEvent?.Invoke();
        }
    }
}