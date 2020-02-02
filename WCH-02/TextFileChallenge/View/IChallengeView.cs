using System.Collections.Generic;

namespace TextFileChallenge.View
{
	public interface IChallengeView
	{
		IList<string> UserList { get; set; }
		int SelectedUser { get; set; }
		string FirstName { get; set; }
		string LastName { get; set; }
		int Age { get; set; }
		bool IsAlive { get; set; }
		Presenter.ChallengePresenter Presenter { set; }
	}
}
