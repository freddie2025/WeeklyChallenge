using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			string continueLooping = "";

			do
			{
				Console.WriteLine("What number do you want to check for prime: ");
				string numToCheckText = Console.ReadLine();
				
				int numToCheck = int.Parse(numToCheckText);
				Dictionary<int, bool?> factors = CheckForPrime(numToCheck);

				if (factors.Count == 0)
				{
					Console.WriteLine($"{ numToCheck } is prime.");
				}
				else
				{
					Console.WriteLine($"{ numToCheck } is a composite number.");
					Console.WriteLine($"There are { factors.Count } factors in { numToCheck }");

					IEnumerable<int> primeFactors = from factor in factors
													where factor.Value == true
													select factor.Key;

					Console.WriteLine($"The largest prime factor is { primeFactors.Max() }");

					Console.WriteLine();
					Console.WriteLine("Here are all of the prime factors:");

					foreach (int factor in primeFactors)
					{
						Console.WriteLine(factor);
					}
				}

				Console.WriteLine();
				Console.Write("Do you want to continue (yes/no): ");
				continueLooping = Console.ReadLine();

			} while (continueLooping.ToLower() == "yes");

			Console.ReadLine();
		}

		private static Dictionary<int, bool?> CheckForPrime(int num)
		{
			Dictionary<int, bool?> output = new Dictionary<int, bool?>();

			int max = num / 2;

			for (int i = 2; i <= max; i++)
			{
				if (num % i == 0)
				{
					output.Add(i, null);
				}
			}

			if (output.Count > 0)
			{
				foreach (var factor in output.Keys.ToList())
				{
					if (CheckForPrime(factor).Count == 0)
					{
						output[factor] = true;
					}
					else
					{
						output[factor] = false;
					}
				}
			}

			return output;
		}
	}
}
