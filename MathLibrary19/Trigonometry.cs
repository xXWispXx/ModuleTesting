using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary19
{
    public static class Trigonometry
    {
        public static double Sin(double a, double b)
        {
            return a / b;
        }

        public static double Cos(double c, double b)
        {
            return c / b;
        }

        public static double Tg(double a, double c)
        {
            return a / c;
        }

        public static double Ctg(double a, double c)
        {
            return 1 / (a / c);
        }

        public static double ArcSin(double a, double b)
        {
            return 1 / (a / b);
        }
    }
}
