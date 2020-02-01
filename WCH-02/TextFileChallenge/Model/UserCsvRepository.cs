using System;
using System.Collections.Generic;
using System.IO;

namespace TextFileChallenge.Model
{
	public class UserCsvRepository : IUserRepository
	{
		private readonly string _csvFilePath;
		private readonly Lazy<List<User>> _users;

		public UserCsvRepository(string fullPath)
		{
			_csvFilePath = fullPath;

			if (!File.Exists(_csvFilePath))
				throw new IOException();

			_users = new Lazy<List<User>>(() =>
			{
				using (var reader = new StreamReader(_csvFilePath))
				{
					return (List<User>)
				}
			});
		}

		private void SaveUserList(List<User> users)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAllUsers()
		{
			return _users.Value;
		}

		public User GetsUser(int id)
		{
			return _users.Value[id];
		}

		public void SaveUser(int id, User user)
		{
			_users.Value[id] = user;
			SaveUserList(_users.Value);
		}
	}
}
