using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5TP
{
    internal class IsoscelesTriangle : Point
    {
        private double baseLength;
        private double sideLength;

        public IsoscelesTriangle(double baseLength, double sideLength)
        {
            this.baseLength = baseLength;
            this.sideLength = sideLength;
        }
        public override double CalculateVirtualArea()
        {
            return baseLength * sideLength / 2;
        }
        public double CalculatePerimetr()
        {
            return baseLength + sideLength * 2;
        }
        public double CalculateArea()
        {
            return baseLength * sideLength / 2;
        }
    }
}
