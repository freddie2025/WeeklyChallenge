using System.Collections.Generic;
using System.Windows.Forms;

namespace TextFileChallenge.View
{
    public partial class ChallengeForm : Form, IChallengeView
    {
        public ChallengeForm()
        {
            InitializeComponent();
        }

        public IList<string> UserList 
        { 
            get { return (IList<string>)this.usersListBox.DataSource; }
            set { this.usersListBox.DataSource = value; }
        }

        public int SelectedUser 
        { 
            get { return this.usersListBox.SelectedIndex; }
            set { this.usersListBox.SelectedIndex = value; }
        }
        
        public string FirstName 
        {
            get { return this.firstNameText.Text; }
            set { this.firstNameText.Text = value; }
        }
        
        public string LastName 
        {
            get { return this.lastNameText.Text; }
            set { this.lastNameText.Text = value; }
        }
        
        public int Age 
        {
            get { return (int)this.agePicker.Value; }
            set { this.agePicker.Value = value; }
        }
        
        public bool IsAlive 
        {
            get { return this.isAliveCheckbox.Checked; }
            set { this.isAliveCheckbox.Checked = value; }
        }
        
        public Presenter.ChallengePresenter Presenter 
        {
            private get; 
            set;
        }

        private void addUserButton_Click(object sender, System.EventArgs e)
        {
            Presenter.UpdateUserView(usersListBox.SelectedIndex);
        }

        private void saveListButton_Click(object sender, System.EventArgs e)
        {
            Presenter.SaveUser();
        }
    }
}
