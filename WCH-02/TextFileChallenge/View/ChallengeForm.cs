using System.ComponentModel;
using System.Windows.Forms;
using TextFileChallenge.Model;

namespace TextFileChallenge.View
{
    public partial class ChallengeForm : Form
    {
        BindingList<User> users = new BindingList<User>();

        public ChallengeForm()
        {
            InitializeComponent();
            WireUpDropDown();
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(User.DisplayText);
        }
    }
}
