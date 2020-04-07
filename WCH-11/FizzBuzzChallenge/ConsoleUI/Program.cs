using System;
using System.Collections.Generic;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			//SimpleSolution();
			//RefactoredSimpleSolution();
			//FlexibleRefactor(0, 120);

			List<DivisibleRuleInfo> rules = new List<DivisibleRuleInfo>();

			rules.Add(new DivisibleRuleInfo("FizzBuzzJazz", new int[] { 3, 5, 7 }));
			rules.Add(new DivisibleRuleInfo("BuzzJazz", new int[] { 5, 7 }));
			rules.Add(new DivisibleRuleInfo("FizzBuzz", new int[] { 3, 5 }));
			rules.Add(new DivisibleRuleInfo("FizzJazz", new int[] { 3, 7 }));
			rules.Add(new DivisibleRuleInfo("Fizz", new int[] { 3 }));
			rules.Add(new DivisibleRuleInfo("Buzz", new int[] { 5 }));
			rules.Add(new DivisibleRuleInfo("Jazz", new int[] { 7 }));

			var results = ReusableRefactor(rules, 0, 120);

			foreach (var result in results)
			{
				Console.WriteLine(result);
			}

			Console.ReadLine();
		}

		private static void SimpleSolution()
		{
			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine($"FizzBuzz ({ i })");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine($"Fizz ({ i })");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine($"Buzz ({ i })");
				}
				else 
				{
					Console.WriteLine(i);
				}
			}
		}

		private static void RefactoredSimpleSolution()
		{
			bool isFizz = false;
			bool isBuzz = false;

			for (int i = 1; i < 101; i++)
			{
				isFizz = (i % 3 == 0);
				isBuzz = (i % 5 == 0);

				if (isFizz && isBuzz)
				{
					Console.WriteLine($"FizzBuzz ({ i })");
				}
				else if (isFizz)
				{
					Console.WriteLine($"Fizz ({ i })");
				}
				else if (isBuzz)
				{
					Console.WriteLine($"Buzz ({ i })");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}

		private static void FlexibleRefactor(int lowerBounds, int upperBounds)
		{
			Dictionary<int, string> rules = new Dictionary<int, string>()
			{
				{3, "Fizz"},
				{5, "Buzz"},
				{7, "Jazz"}
			};

			for (int i = lowerBounds; i <= upperBounds; i++)
			{
				string result = "";

				if (i == 0)
				{
					Console.WriteLine(0);
					continue;
				}

				foreach (var rule in rules)
				{
					if (i % rule.Key == 0)
					{
						result += rule.Value;
					}
				}

				if (result.Length > 0)
				{
					Console.WriteLine($"{ result } ({ i })");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}

		private static bool NumIsDivisibleBy(int num, int[] values)
		{
			bool output = true;

			for (int i = 0; i < values.Length; i++)
			{
				if (num % values[i] != 0)
				{
					output = false;
					break;
				}
			}

			return output;
		}

		private static List<string> ReusableRefactor(List<DivisibleRuleInfo> rules, int lowerBounds, int upperBounds)
		{
			List<string> output = new List<string>();

			for (int i = lowerBounds; i <= upperBounds; i++)
			{
				bool isFound = false;

				if (i == 0)
				{
					output.Add("0");
					continue;
				}

				foreach (var rule in rules)
				{
					if (NumIsDivisibleBy(i, rule.MustBeDivisibleBySet))
					{
						output.Add($"{ rule.WordToPrint } ({ i })");
						isFound = true;
						break;
					}
				}

				if (isFound == false)
				{
					output.Add(i.ToString());
				}
			}

			return output;
		}
	}

	public struct DivisibleRuleInfo
	{
		public string WordToPrint;
		public int[] MustBeDivisibleBySet;

		public DivisibleRuleInfo(string word, int[] numberSet)
		{
			WordToPrint = word;
			MustBeDivisibleBySet = numberSet;
	}
	}
}
