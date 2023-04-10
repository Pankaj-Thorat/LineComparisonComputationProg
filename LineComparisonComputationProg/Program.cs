using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            //input
            Console.Write("Enter the x-coordinate of the first point: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the first point: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the x-coordinate of the second point: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the second point: ");
            double y2 = double.Parse(Console.ReadLine());

            // Calculate the length of the line using the distance formula
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // result 
            Console.WriteLine("The length of the line is: {0}", length);

        }
    }
}
