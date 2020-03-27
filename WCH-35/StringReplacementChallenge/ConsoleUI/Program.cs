using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			//PrimaryChallenge();
			BonusChallenge();

			Console.ReadLine();
		}

		private static void PrimaryChallenge()
		{ 
			List<string> primaryLines = File.ReadAllLines(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-35\primary.txt").ToList();

			Console.Write("Please give me the text to replace: ");
			string toReplace = Console.ReadLine();

			Console.Write("Please give me the replacement text: ");
			string replacementText = Console.ReadLine();

			for (int i = 0; i < primaryLines.Count; i++)
			{
				primaryLines[i] = primaryLines[i].Replace(toReplace, replacementText);
			}

			File.WriteAllLines(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-35\primary.txt", primaryLines);

			Console.WriteLine("The text file has been updated");
		}

		private static void BonusChallenge()
		{
			string bonusText = File.ReadAllText(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-35\bonus.txt");

			// {FirstName}
			var results = Regex.Matches(bonusText, @"{[^{}]+}")
				.Cast<Match>()
				.Select(x => x.Value.Substring(1, x.Value.Length - 2))
				.ToHashSet();

			foreach (var result in results)
			{
				Console.Write($"Please give me the value for { result }: ");
				bonusText = bonusText.Replace("{"+ result + "}", Console.ReadLine());
			}

			File.WriteAllText(@"C:\Users\Fred James\OneDrive\Code\GitHub\WeeklyChallange\WCH-35\bonus.txt", bonusText);
		}
	}
}
