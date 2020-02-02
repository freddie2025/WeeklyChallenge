using System.Linq;
using TextFileChallenge.Model;
using TextFileChallenge.View;

namespace TextFileChallenge.Presenter
{
	public class ChallengePresenter
	{
		private readonly IChallengeView _view;
		private readonly IUserRepository _repository;

		public ChallengePresenter(IChallengeView view, IUserRepository repository)
		{
			_view = view;
			view.Presenter = this;
			_repository = repository;

			UpdateUserListView();
		}

		private void UpdateUserListView()
		{
			var userDisplayText = _repository.GetAllUsers().Select(users => users.DisplayText);
			int selectedUser = _view.SelectedUser >= 0 ? _view.SelectedUser : 0;
			_view.UserList = userDisplayText.ToList();
			_view.SelectedUser = selectedUser;
		}

		public void UpdateUserView(int id)
		{
			User user = _repository.GetsUser(id);
			_view.FirstName = user.FirstName;
			_view.LastName = user.LastName;
			_view.Age = user.Age;
			_view.IsAlive = user.IsAlive;
		}

		public void SaveUser()
		{
			User user = new User 
			{ 
				FirstName = _view.FirstName, 
				LastName = _view.LastName, 
				Age = _view.Age, 
				IsAlive = _view.IsAlive 
			};
			_repository.SaveUser(_view.SelectedUser, user);
			UpdateUserListView();
		}
	}
}