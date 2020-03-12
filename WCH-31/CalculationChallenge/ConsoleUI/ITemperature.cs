namespace ConsoleUI
{
	public interface ITemperature
	{
		double AverageTemperature { get; }
		int MaximumTemperature { get; }
		int MinimumTemperature { get; }

		void Insert(int temperature);
		void Insert(string temperature);
	}
}