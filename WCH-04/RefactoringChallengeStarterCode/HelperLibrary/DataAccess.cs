using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace HelperLibrary
{
	public static class DataAccess
	{
		public static string GetConnectionString(string name = "DapperDemoDB")
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}

		public static List<T> ReadData<T>(string sql, object p)
		{
			using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
			{
				var output = cnn.Query<T>(sql, p, commandType: CommandType.StoredProcedure).ToList();

				return output;
			}
		}

		public static void WriteData(string sql, object p)
		{
			using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
			{
				cnn.Execute(sql, p, commandType: CommandType.StoredProcedure);
			}
		}
	}
}
