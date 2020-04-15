using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsoleUI
{
	class Program
	{
		private static HttpClient apiClient;
		private static List<PersonModel> peopleCache = new List<PersonModel>();

		static async Task Main(string[] args)
		{
			InitializeClient();
			string lookupAnother = "";

			do
			{
				Console.Write("What id would you like to use: ");
				string idText = Console.ReadLine();

				try
				{
					PersonModel person = await GetStarWarsCharacter(idText);

					Console.WriteLine($"{ person.FullName } is a { person.Gender }");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: { ex.Message }");
				}

				Console.Write("Do you want to look up another character (yes/no): ");
				lookupAnother = Console.ReadLine();

				Console.Clear();
			} while (lookupAnother.ToLower() == "yes");

			Console.ReadLine();
		}

		private static async Task<PersonModel> GetStarWarsCharacter(string id)
		{
			string url = $"https://swapi.co/api/people/{ id }/";

			PersonModel cached = peopleCache.Where(x => x.Id == id).FirstOrDefault();

			if (cached != null)
			{
				return cached;
			}

			using (HttpResponseMessage response = await apiClient.GetAsync(url))
			{
				if (response.IsSuccessStatusCode)
				{
					PersonModel output = await response.Content.ReadAsAsync<PersonModel>();
					
					peopleCache.Add(output);
					
					return output;
				}
				else 
				{
					throw new Exception(response.ReasonPhrase);
				}
			}
		}

		private static void InitializeClient()
		{
			apiClient = new HttpClient();
			apiClient.DefaultRequestHeaders.Accept.Clear();
			apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		}
	}
}
