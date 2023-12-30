// Write a function to
// print Fibonacci series for the number
// of terms entered by the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of terms for the Fibonacci Series : ");
            int numbers = int.Parse(Console.ReadLine());

            int firstTerm = 0;
            int secondTerm = 1;

            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine($"{firstTerm}");

                int nextTerm = firstTerm + secondTerm;
                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
            Console.ReadKey();
        }
    }
}
