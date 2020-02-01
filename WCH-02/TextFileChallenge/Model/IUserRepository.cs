using System.Collections.Generic;

namespace TextFileChallenge.Model
{
	public interface IUserRepository
	{
		IEnumerable<User> GetAllUsers();

		User GetsUser(int id);

		void SaveUser(int id, User user);
	}
}
