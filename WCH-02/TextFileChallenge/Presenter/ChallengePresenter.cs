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
		}
		
		private void UpdateUserListView()
		{ 

		}
	}
}