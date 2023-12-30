using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select One Shape : ");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Rectangle");

            int shapeChoice = int.Parse(Console.ReadLine());

            double area = 0;
            double perimeter = 0;

            switch (shapeChoice)
            {
                case 1:
                    Console.WriteLine("Enter the length of side of a Square : ");
                    double side = double.Parse(Console.ReadLine());

                    area = side*side;
                    perimeter = 4 * side;
                    break;
                case 2:
                    Console.WriteLine("Enter the radius of the Cicle :");
                    double radius = double.Parse(Console.ReadLine());

                    area = 3.14 * radius*radius;
                    perimeter = 2 * 3.14 * radius;
                    break;
                case 3:
                    Console.WriteLine("Enter length of the Rectangle : ");
                    double length = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Width of the Rectangle : ");
                    double width = double.Parse(Console.ReadLine());    

                    area = length*width;
                    perimeter = 2 * (length + width);
                    break;
            }
            Console.WriteLine("Results :");
            Console.WriteLine($"Area : {area}");
            Console.WriteLine($"Perimeter : {perimeter}");

            Console.ReadKey();
        }
    }
}
