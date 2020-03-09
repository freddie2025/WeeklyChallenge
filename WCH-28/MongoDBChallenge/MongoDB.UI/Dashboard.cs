using MongoDB.Library;
using MongoDB.Library.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MongoDB.UI
{
	public partial class Dashboard : Form
	{
		List<PersonModel> people;
		private const string databaseName = "ChallenegDB";
		private const string personTable = "People";
		PersonModel currentPerson = new PersonModel();

		public Dashboard()
		{
			InitializeComponent();

			LoadPersonData();
		}

		private void LoadPersonData()
		{
			MongoCRUD db = new MongoCRUD(databaseName);
			people = db.LoadRecords<PersonModel>(personTable);

			people.Insert(0, new PersonModel { FirstName = "<add new person>"});

			peopleDropDown.DataSource = people;
		}

		private void submitButton_Click(object sender, System.EventArgs e)
		{
            if (string.IsNullOrWhiteSpace(phoneNumberText.Text))
            {
                MessageBox.Show("You need to enter a phone number.");
                return;
            }

            currentPerson.FirstName = firstNameText.Text;
            currentPerson.LastName = lastNameText.Text;
            currentPerson.EmailAddress = emailText.Text;
            currentPerson.PhoneNumber = phoneNumberText.Text;

            MongoCRUD db = new MongoCRUD(databaseName);

            if (currentPerson.Id == Guid.Empty)
            {
                var foundPeople = db.FindRecordByNames<PersonModel>(personTable, currentPerson.FirstName, currentPerson.LastName);

                if (foundPeople.Count > 0)
                {
                    foreach (var foundPerson in foundPeople)
                    {
                        currentPerson.Id = foundPerson.Id;
                        db.UpsertRecord(personTable, foundPerson.Id, currentPerson);
                    }
                }
                else
                {
                    db.InsertRecord(personTable, currentPerson);
                }
            }
            else
            {
                db.UpsertRecord(personTable, currentPerson.Id, currentPerson);
            }

            firstNameText.Text = "";
            lastNameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
            currentPerson = new PersonModel();
            LoadPersonData();
        }

		private void PeopleDropDown_SelectedindexChanged(object sender, System.EventArgs e)
		{
            PersonModel selectedPerson = (PersonModel)peopleDropDown.SelectedItem;

            if (string.IsNullOrWhiteSpace(selectedPerson.LastName) == false)
            {
                currentPerson = selectedPerson;
                firstNameText.Text = currentPerson.FirstName;
                lastNameText.Text = currentPerson.LastName;
                emailText.Text = currentPerson.EmailAddress;
                phoneNumberText.Text = currentPerson.PhoneNumber;
            }
            else
            {
                currentPerson = new PersonModel();
                firstNameText.Text = "";
                lastNameText.Text = "";
                emailText.Text = "";
                phoneNumberText.Text = "";
            }
        }
	}
}
