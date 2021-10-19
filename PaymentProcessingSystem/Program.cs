using System;

namespace PaymentProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product type* (e.g. Video, Membership, Upgrade,  Book, Other) and name (optional) seperated by space.");
            Console.WriteLine();

            var userInput = Console.ReadLine().Split(' ');
            var systemOutput = PaymentProcessor.UserInputToProductType(userInput);
            Console.WriteLine();
        }
    }
}
