using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5TP
{
    internal class Quadrant : Point
    {
        private double sideLength;

        public Quadrant(double sideLength)
        {
            this.sideLength = sideLength;
        }
        public override double CalculateVirtualArea()
        {
            return sideLength * sideLength;
        }
        public double CalculateArea()
        {
            return sideLength * sideLength;
        }
        public double CalculateDiagonal()
        {
            return Math.Sqrt(2) * sideLength;
        }
        public double CalculatePerimeter()
        {
            return 4 * sideLength;
        }
    }
}
