using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			var people = GetPeopleStrings();

			foreach (var person in people)
			{
				Console.WriteLine($"Hello {person}");
			}

			Console.ReadLine();

			foreach (var personModel in GetPersonModels())
			{
				Console.WriteLine($"Hello {personModel.FirstName} {personModel.LastName}");
			}

			Console.ReadLine();
		}

		private static List<PersonModel> GetPersonModels() => 
			new List<PersonModel>()
			{ 
				new PersonModel { FirstName="Tim", LastName="Corey" },
				new PersonModel { FirstName="Bill", LastName="McCoy" },
				new PersonModel { FirstName="Mary", LastName="Jones" },
				new PersonModel { FirstName="Sue", LastName="Smith" },
			};

		private static List<string> GetPeopleStrings() =>
			new List<string>()
			{
				"John",
				"Mary",
				"Sue",
				"Greg",
				"Yolanda",
				"Jose",
				"Will",
			};
	}
}
