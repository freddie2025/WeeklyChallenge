using System;
using System.Linq;
using System.Text;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = "Hello World";

			//var letters = from x in input
			//			 orderby x.ToString()
			//			 select x;

			//foreach (var letter in letters)
			//{
			//	Console.WriteLine(letter);
			//}

			//Console.WriteLine(input.OrderBy(x => Char.ToLower(x)).Aggregate(new StringBuilder(), (x, y) => x.Append(y)));

			var letters = from x in input
						  group x by x.ToString().ToLower() into y
						  orderby y.Count() descending, y.Key.ToString()
						  select (new { letter = y.Key, Count = y.Count() });

			foreach (var letter in letters)
			{
				Console.WriteLine($"Letter: { letter.letter }, count: { letter.Count }");
			}

			Console.ReadLine();
		}
	}
}
