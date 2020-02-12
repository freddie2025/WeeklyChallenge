using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    var result = paymentProcessor.MakePayment($"Demo{ i }", i);

                    Console.WriteLine(result.TransactionAmount);
                }
                catch (FormatException ex)
                {
                    if (i != 5)
                    {
                        Console.WriteLine("Formatting Issue " + ex.InnerException);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"Skipped invalid record " + ex.InnerException);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine($"Null value for item { i } " + ex.InnerException);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Payment skipped for payment with { i } items " + ex.InnerException);
                }
            }
            Console.ReadLine();
        }
    }
}
