using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5TP
{
    internal class Circle : Point
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateVirtualArea()
        {
            return Math.PI * radius * radius;
        }
        public double CalculateDiametr()
        {
            return 2 * radius;
        }
    }
}
