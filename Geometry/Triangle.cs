using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle:Shape
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double CalculateArea()
        {
            double s = (_a + _b + _c) / 2;
            return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
        }

        public  bool IsRightTriangle(double a, double b, double c)
        {
            return a * a + b * b == c * c || b * b + c * c == a * a || c * c + a * a == b * b;
        }
    }
}
