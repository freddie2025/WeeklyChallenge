using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
	public class Temperature : ITemperature
	{
		private List<int> temperatures = new List<int>();
		private Dictionary<string, int> words = new Dictionary<string, int>();

		public int MinimumTemperature 
		{
			get 
			{ 
				return temperatures.Min();
			}
		}

		public int MaximumTemperature
		{
			get
			{
				return temperatures.Max();
			}
		}

		public double AverageTemperature
		{
			get
			{
				return temperatures.Average();
			}
		}

		public Temperature()
		{
			words.Add("one", 1);
			words.Add("two", 2);
			words.Add("three", 3);
			words.Add("four", 4);
			words.Add("five", 5);
			words.Add("six", 6);
			words.Add("seven", 7);
			words.Add("eight", 8);
			words.Add("nine", 9);
			words.Add("ten", 10);
		}

		public void Insert(int temperature)
		{
			temperatures.Add(temperature);
		}

		public void Insert(string temperature)
		{
			temperature = temperature.ToLower();
			Insert(words[temperature]);
		}
	}
}
