using System;

namespace TriangleIdentifierProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle Identifier Program");
            Console.WriteLine("============================");

            try
            {
                Console.WriteLine("Enter the lengths of the three sides of the triangle:");

                Console.Write("Side A: ");
                double sideA = Convert.ToDouble(Console.ReadLine());

                Console.Write("Side B: ");
                double sideB = Convert.ToDouble(Console.ReadLine());

                Console.Write("Side C: ");
                double sideC = Convert.ToDouble(Console.ReadLine());

                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("The Triangle is Equilateral.");
                }
                else if (sideA == sideB || sideB == sideC || sideA == sideC)
                {
                    Console.WriteLine("The Triangle is Isosceles.");
                }
                else
                {
                    Console.WriteLine("The Triangle is Scalene.");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Only enter numeric values");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press any Key to exit");
                Console.ReadKey();

            }
    
           
        }

    }
}