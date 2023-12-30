/* Write a function Prime() which checks the 
 * user entered number passed to 
 * it is a prime number or not. 
 * In this function call another function called Check() 
 * which returns the status of the number 
 * whether it is positive or negative 
 * and pass it to main function. 
 * If the number is negative, 
 * ask user to re-enter the number or else 
 * print the positive number.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number;

            // Prompt user until a valid number is entered
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Check the status of the number (positive/negative)
            string status = Check(number);

            if (status == "positive")
            {
                // If positive, check if it's a prime number
                if (Prime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
            else
            {
                // If negative, prompt the user to re-enter the number
                Console.WriteLine("Please re-enter a positive number.");
            }

            Console.ReadKey();
        }

        // Function to check if a number is prime
        static bool Prime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        // Function to check if a number is positive or negative
        static string Check(int n)
        {
            return n >= 0 ? "positive" : "negative";
        }
    }
}

