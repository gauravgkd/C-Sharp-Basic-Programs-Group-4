//Write a function to accept
//day, month and year from the user
//in a function called getDate()
//and print that date in main.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime userDate = GetDate();

                Console.WriteLine($"Date Entered : {userDate:d}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            Console.ReadKey();
        }

        static DateTime GetDate()
        {
            int day, month, year;

            Console.WriteLine("Enter Day : ");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Month : ");
            month = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Enter Year : ");
            year = int.Parse(Console.ReadLine());

            DateTime userDate = new DateTime(year, month, day);

            return userDate;

        }

        static int GetValidIntegerInput()
        {
            while (true)
            {
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Invalid Input. Please Enter a Valid Integer.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid Input. The Number is too large or too small.");
                }

            }
        }
    }
}
