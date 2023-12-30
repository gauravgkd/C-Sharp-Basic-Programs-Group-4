//Write a program to generate
//all positive combinations of 1,2,3
//using for loop.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

            Console.WriteLine("All Positive Combinations : ");

            GenerateCombinations(numbers);

            Console.ReadKey();
        }

        static void GenerateCombinations(int[] numbers)
        {
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                       for(int k = 0; k < length; k++)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]} {numbers[k]}");
                    }
                }
            }
        }
    }
}
