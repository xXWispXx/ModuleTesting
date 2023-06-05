using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary19
{
    public static class Geometry
    {
        public static double SReactangle(double a, double b)
        {
            return a * b;
        }

        public static double STriangle(double a, double h)
        {
            return 0.5 * (a * h);
        }

        public static double SRectangleTriangle(double a, double b)
        {
            return 0.5 * a * b;
        }

        public static double SCircle(double r)
        {
            return Math.Round(Math.PI * (Math.Pow(r, 2)), 2);
        }

        public static double STrapezoid(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }
    }
}
