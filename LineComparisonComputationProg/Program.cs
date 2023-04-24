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

            // Create Line objects
            Line line1 = new Line(x1_l1, y1_l1, x2_l1, y2_l1);
            Line line2 = new Line(x1_l2, y1_l2, x2_l2, y2_l2);

            // Compare the end points of line 1 and line 2
            if (line1.Equals(line2))
            {
                Console.WriteLine("Line 1 and Line 2 are equal");
            }
            else if (line1.GreaterThan(line2))
            {
                Console.WriteLine("Line 1 is greater than Line 2");
            }
            else
            {
                Console.WriteLine("Line 1 is less than Line 2");
            }
        }
    }
}

