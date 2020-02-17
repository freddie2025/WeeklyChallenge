using System.Collections.Generic;

namespace HelperLibrary
{
	public static class BusinessLogic
	{
		public static List<SystemUserModel> GetAllUsers()
		{
			return DataAccess.ReadData<SystemUserModel>("[dbo].[spSystemUser_Get]", new { });
		}

		public static List<SystemUserModel> GetAllUsers_Filtered(string filter)
		{
			var p = new
			{
				Filter = filter
			};

			return DataAccess.ReadData<SystemUserModel>("[dbo].[spSystemUser_GetFiltered]", p);
		}

		public static void CreateUser(string firstName, string lastName)
		{
			var p = new
			{
				FirstName = firstName,
				LastName = lastName
			};

			DataAccess.WriteData("[dbo].[spSystemUser_Create]", p);
		}
	}
}
