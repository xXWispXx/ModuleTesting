using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary19
{
    public static class AlgebraEquation
    {
        public static string QuadraticEquation(double a, double b, double c)
        {
            if ((Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) > 0)
            {
                string x1 = ((-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a)).ToString();
                string x2 = ((-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a)).ToString();

                string ans2 = "Корень х1: " + x1 + ", корень х2: " + x2;
                return ans2;

            }
            if ((Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) == 0)
            {
                string x = (-(b / 2 * a)).ToString();
                return x;

            }
            else
            {
                string ans = "Корней нет";
                return ans;
            }
        }

        public static string linearEquation(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                return "Корней нет";
            }
            else if (a == 0 && b == 0)
            {
                return "х принадлежит множеству рациональных чисел";
            }
            else
            {
                double x = (-(b / a));
                return x.ToString();
            }
        }
    }

 }
