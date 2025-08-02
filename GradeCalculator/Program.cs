using System;

namespace Program
{
    class GreadeCalculatorProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Calculator");
            Console.WriteLine("===================================");

            try
            {
                Console.WriteLine("Enter Your Score (0-100): ");
                int score = int.Parse(Console.ReadLine());

                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid score, Your score should be between 0 and 100(inclusive)");
                }
                else if (score >= 90)
                {
                    Console.WriteLine("Your Grade is: A");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("Your Grade is: B");
                }
                else if (score >= 70)
                {
                    Console.WriteLine("Your Grade is: C");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("Your Grade is: D");
                }
                else
                {
                    Console.WriteLine(score <= 0 ? "Your Grade is: F" : "invalid score, Your score should be between 0 and 100(inclusive)");
                }

            }
            catch (FormatException) { 
                Console.WriteLine("Invaild input, please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input is too large or too small for an Int32.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press any Key to exit.");
                Console.ReadKey();
            }
        }
    }
}