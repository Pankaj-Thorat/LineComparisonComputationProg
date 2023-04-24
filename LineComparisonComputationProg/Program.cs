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

            // input for line 1
            Console.Write("Enter the x-coordinate of the first point of line 1: ");
            double x1_l1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the first point of line 1: ");
            double y1_l1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the x-coordinate of the second point of line 1: ");
            double x2_l1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the second point of line 1: ");
            double y2_l1 = double.Parse(Console.ReadLine());

            // input for line 2
            Console.Write("Enter the x-coordinate of the first point of line 2: ");
            double x1_l2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the first point of line 2: ");
            double y1_l2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the x-coordinate of the second point of line 2: ");
            double x2_l2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the y-coordinate of the second point of line 2: ");
            double y2_l2 = double.Parse(Console.ReadLine());

            // Calculate the length of line 1 and line 2 using the distance formula
            double length_l1 = Math.Sqrt(Math.Pow(x2_l1 - x1_l1, 2) + Math.Pow(y2_l1 - y1_l1, 2));
            double length_l2 = Math.Sqrt(Math.Pow(x2_l2 - x1_l2, 2) + Math.Pow(y2_l2 - y1_l2, 2));

            // Compare the end points of line 1 and line 2
            if (length_l1 == length_l2)
            {
                Console.WriteLine("Line 1 and Line 2 are equal in length");
            }
            else if (length_l1 > length_l2)
            {
                Console.WriteLine("Line 1 is greater than Line 2 in length");
            }
            else
            {
                Console.WriteLine("Line 1 is less than Line 2 in length");
            }
        }
    }
}

