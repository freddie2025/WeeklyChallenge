using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace TextFileChallenge.Model
{
	public class UserCsvRepository : IUserRepository
	{
		private readonly string _csvFilePath;
		private readonly Lazy<List<User>> _users;

		public UserCsvRepository(string fullPath)
		{
			_csvFilePath = fullPath + @"\AdvancedDataSet.csv";

			if (!File.Exists(_csvFilePath))
				throw new IOException();

			_users = new Lazy<List<User>>(() =>
			{
				using (var reader = new StreamReader(_csvFilePath))
				using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
				{
					return csvReader.GetRecords<User>().ToList();
				}
			});
		}

		private void SaveUserList(List<User> users)
		{
			using (var writer = new StreamWriter(_csvFilePath))
			using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
			{
				csv.WriteRecords(users);
			}
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
