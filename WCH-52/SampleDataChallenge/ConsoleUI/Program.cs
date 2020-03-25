using SampleDataLibrary;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			Sample sample = new Sample();

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(sample.GenerateRandomNumberMatch("(xxx) xxx-xxxx"));
			}

			Console.ReadLine();
		}
	}
}
