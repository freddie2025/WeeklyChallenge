using System;

namespace ConsoleUI
{
	public static class Extensions
	{
		public static void Print(this string input)
		{
			Console.WriteLine(input);
		}

		public static string Excite(this string input)
		{
			return input.Replace('.', '!');
		}

		public static PersonModel Fill(this PersonModel input)
		{
			Console.Write("Please enter your first name: ");
			input.FirstName = Console.ReadLine();

			Console.Write("Please enter your last name: ");
			input.LastName = Console.ReadLine();

			Console.Write("Please enter your age: ");
			string ageText = Console.ReadLine();

			input.Age = int.Parse(ageText);

			return input;
		}

		public static PersonModel Print(this PersonModel input)
		{
			Console.WriteLine($"{ input.FirstName } { input.LastName } is { input.Age } years old.");

			return input;
		}

		public static double Add(this double input, double x)
		{
			return input + x;
		}

		public static double Subtract(this double input, double x)
		{
			return input - x;
		}

		public static double MultiplyBy(this double input, double x)
		{
			return input * x;
		}

		public static double DivideBy(this double input, double x)
		{
			return input / x;
		}
	}
}
