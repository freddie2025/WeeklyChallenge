using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			List<DenominationInfo> denominations = new List<DenominationInfo>();

			denominations.Add(new DenominationInfo { Name = "Nickle", Amount = 0.05M });
			denominations.Add(new DenominationInfo { Name = "Quarter", Amount = 0.25M });
			denominations.Add(new DenominationInfo { Name = "Penny", Amount = 0.01M });
			denominations.Add(new DenominationInfo { Name = "Dime", Amount = 0.10M });
			denominations.Add(new DenominationInfo { Name = "One Dollar Bill", Amount = 1.00M });
			denominations.Add(new DenominationInfo { Name = "Five Dollar Bill", Amount = 5.00M });
			denominations.Add(new DenominationInfo { Name = "Ten Dollar Bill", Amount = 10.00M });

			Console.Write("Please enter the amount owed: ");
			decimal amountOwed = decimal.Parse(Console.ReadLine());

			Console.Write("Please enter the amount paid: ");
			decimal amountPaid = decimal.Parse(Console.ReadLine());

			List<string> results = CalculateChange(amountOwed, amountPaid, denominations);

			foreach (var result in results)
			{
				Console.WriteLine(result);
			}

			Console.ReadLine();
		}

		private static List<string> CalculateChange(decimal amountOwed, decimal amountPaid, List<DenominationInfo> denominations)
		{ 
			List<string> output = new List<string>();
			decimal change = amountPaid - amountOwed;

			if (change < 0)
			{
				output.Add("You need to pay more.");
			}
			else if (change == 0)
			{
				output.Add("No change required.");
			}
			else // change > 0
			{
				var orderedDenomonations = denominations.OrderByDescending(x => x.Amount);
				int count = 0;

				foreach (var denomination in orderedDenomonations)
				{
					(change, count) = CalculateSpecificChange(change, denomination.Amount);

					if (count > 0)
					{
						output.Add($"{ count } { denomination.Name }");
					}
				}
			}

			return output;
		}

		private static (decimal remainder, int numberOfItems) CalculateSpecificChange(decimal amount, decimal denomination)
		{
			(decimal remainder, int numberOfItems) output = (0, 0);

			// 0.77 / 0.25 = 3.00825s
			output.numberOfItems = (int)Math.Floor(amount / denomination);
			output.remainder = amount - (output.numberOfItems * denomination);

			return output;
		}
	}
}
