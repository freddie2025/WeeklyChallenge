using System;

namespace DateTimeChallengeUI
{
    class Program
	{
		static void Main(string[] args)
		{
            // Capture date from console calculate how many days ago it was
            Console.Write("Give me a date: ");
            string previousDateString = Console.ReadLine();

            Console.Write("what date format do you want to use: ");
            string dateFormat = Console.ReadLine();

            if (dateFormat.Length < 1)
            {
                dateFormat = "M/d/yy";
            }

            DateTime previousDate = DateTime.ParseExact(previousDateString, dateFormat, null);

            TimeSpan fromPreviousDate = DateTime.Now.Subtract(previousDate);

            if (fromPreviousDate.Ticks < 0)
            {
                Console.WriteLine($"{ previousDateString } is { Math.Round(-fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero) } days in the future.");
            }
            else
            {
                Console.WriteLine($"It has been { Math.Round(fromPreviousDate.TotalDays, 0, MidpointRounding.AwayFromZero) } days since { previousDateString }");
            }

            Console.Write("Give me a time: ");
            string previousTimeString = Console.ReadLine();

            Console.Write("What time format do you want to use: ");
            string timeFormat = Console.ReadLine();

            if (timeFormat.Length < 1)
            {
                timeFormat = "h:mm tt";
            }

            DateTime previousTime = DateTime.ParseExact(previousTimeString, timeFormat, null);

            TimeSpan fromPreviousTime = DateTime.Now.Subtract(previousTime);

            if (fromPreviousTime.Ticks < 0)
            {
                fromPreviousTime = fromPreviousTime.Add(TimeSpan.FromHours(24));
            }

            Console.WriteLine($"{ previousTimeString } was { fromPreviousTime.Hours } hours and { fromPreviousTime.Minutes } minutes ago.");

            Console.ReadLine();
        }
	}
}
