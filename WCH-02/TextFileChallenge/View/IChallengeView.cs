using System.Collections.Generic;

namespace TextFileChallenge.View
{
	public interface IChallengeView
	{
		IList<string> UserList { get; set; }
		Presenter.ChallengePresenter Presenter { set; }
	}
}
