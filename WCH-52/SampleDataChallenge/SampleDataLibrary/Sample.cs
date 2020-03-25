using System;
using System.IO;

namespace SampleDataLibrary
{
	public class Sample
	{
		Random rnd;

		public Sample()
		{
			rnd = new Random();
		}

		public bool GenerateRandomBool()
		{
			return rnd.NextDouble() >= 0.5;
		}

		public int GenerateRandomInt(int floor = 0, int ceiling = 100)
		{
			return rnd.Next(floor, ceiling);
		}

		public double GenerateRandomDouble(double floor = 0, double ceiling = 100)
		{
			double output = rnd.NextDouble();

			output = (output * (ceiling - floor)) + floor;

			return output;
		}

		public string GenerateRandomFirstName()
		{
			string[] names = File.ReadAllLines(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-52\FirstNames.txt");
			int randomInt = GenerateRandomInt(0, names.Length);

			return names[randomInt];
		}

		public string GenerateRandomLastName()
		{
			string[] names = File.ReadAllLines(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-52\LastNames.txt");
			int randomInt = GenerateRandomInt(0, names.Length);

			return names[randomInt];
		}

		public string GenerateRandomFullName()
		{
			return $"{ GenerateRandomFirstName() } { GenerateRandomLastName() }";
		}

		public string GenerateRandomZipCode()
		{
			return GenerateRandomNumberMatch("xxxxx-xxxxx");
		}

		public string GenerateRandomPhoneNumber()
		{
			return GenerateRandomNumberMatch("(xxx) xxx-xxxx");
		}

		public string GenerateRandomNumberMatch(string pattern)
		{
			// xxxxx
			// xxxxx-xxxxx
			// (xxx) xxx-xxxx
			string output = pattern;

			while (output.Contains("x"))
			{
				int position = output.IndexOf("x");
				output = output.Substring(0, position) + GenerateRandomInt(0, 10) + output.Substring(position + 1); 
			}

			return output;
		}
	}
}
