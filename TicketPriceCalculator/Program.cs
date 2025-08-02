using System;

namespace TicketPriceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int originalTicketPrice = 10; // Original ticket price
            int discountPrice = 7; // Discounted ticket price

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 12 || age >= 65)
            {
                Console.WriteLine("The Ticket Price is GHC:" + discountPrice); 
            }
            else
            {
                Console.WriteLine("The Ticket Price is GHC:" + originalTicketPrice);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}