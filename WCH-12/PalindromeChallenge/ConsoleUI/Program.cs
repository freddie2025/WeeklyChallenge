using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("PLease enter a string: ");
			string textToCheck = Console.ReadLine();

			Console.WriteLine($"Text check: { TextIsPalindrome(textToCheck) }");

			Console.WriteLine($"Int check: { IntIsPalindrome(12321) }");

			Console.WriteLine($"Double check: { DoubleIsPalindrome(12.321) }");

			Console.ReadLine();
		}

		private static bool IntIsPalindrome(int number)
		{
			return TextIsPalindrome(number.ToString());
		}

		private static bool DoubleIsPalindrome(double number)
		{
			return TextIsPalindrome(number.ToString());
		}

		private static bool TextIsPalindrome(string text)
		{
			Regex charactersWeCareAboutCheck = new Regex("[^a-zA-Z0-9]");
			text = charactersWeCareAboutCheck.Replace(text, "");
			text = text.ToUpper();

			char[] backwards = text.Reverse().ToArray();
			//char[] forwards = text.ToArray();

			//bool output = true;

			//for (int i = 0; i < backwards.Length; i++)
			//{
			//	if (backwards[i] != forwards[i])
			//	{
			//		output = false;
			//		break;
			//	}
			//}

			string backwardsText = new string(backwards);

			bool output = string.Compare(text, backwardsText) == 0;

			return output;
		}
	}
}
