using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputationProg
{
    class Line
    {
        private double x1, y1, x2, y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public bool Equals(Line other)
        {
            return (x1 == other.x1 && y1 == other.y1 && x2 == other.x2 && y2 == other.y2) ||
                   (x1 == other.x2 && y1 == other.y2 && x2 == other.x1 && y2 == other.y1);
        }

        public bool GreaterThan(Line other)
        {
            return Length() > other.Length();
        }

        public bool LessThan(Line other)
        {
            return Length() < other.Length();
        }
    }
}
