using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            for (int i = 0; i <= 10; i++)
            {
                var result = paymentProcessor.MakePayment($"Demo{ i }", i);

                Console.WriteLine(result.TransactionAmount);
            }
            Console.ReadLine();
        }
    }
}
