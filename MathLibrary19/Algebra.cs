using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary19
{
    public static class Algebra
    {
        public static double Sum (double a, double b)
        {
            return a + b;
        }

        public static double Avg(double a, double b)
        {
            return (a + b) / 2;
        }

        public static double Max(double a, double b)
        {
            return Math.Max(a, b);
        }
    }

}
