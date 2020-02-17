using System;
using static HelperLibrary.BusinessLogic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string actionToTake = "";

            do
            {
                Console.Write("What action do you want to take (Display, Add, or Quit): ");
                actionToTake = Console.ReadLine();

                switch (actionToTake.ToLower())
                {
                    case "display":
                        var records = GetAllUsers();

                        Console.WriteLine();
                        records.ForEach(x => Console.WriteLine(x.FullName));
                        Console.WriteLine();
                        break;
                    case "add":
                        Console.Write("What is the first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("What is the last name: ");
                        string lastName = Console.ReadLine();

                        CreateUser(firstName, lastName);

                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (actionToTake.ToLower() != "quit");
        }
    }
}
