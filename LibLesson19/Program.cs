using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLibrary19;
using My13Math;

namespace My13Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Геометрия
            Console.WriteLine("Геометрия");
            Console.WriteLine(" ");
            Console.WriteLine("Площадь прямоугольника = " + Geometry.SReactangle(3, 7));
            Console.WriteLine("Площадь треугольника = " + Geometry.STriangle(3, 7));
            Console.WriteLine("Площадь круга = " + Geometry.SCircle(5));
            Console.WriteLine("Площадь треугольного прямоугольника = " + Geometry.SRectangleTriangle(7, 3));
            Console.WriteLine("Площадь прямоугольника трапеции = " + Geometry.STrapezoid(3,4,7));
            Console.WriteLine(" ");

            //Тригонометрия
            Console.WriteLine("Тригонометрия");
            Console.WriteLine(" ");
            Console.WriteLine("Синус" +Trigonometry.Sin(7,5));
            Console.WriteLine("Косинус" + Trigonometry.Cos(7,5));
            Console.WriteLine("Тангенс" + Trigonometry.Tg(10,7));
            Console.WriteLine("Катангенс" + Trigonometry.Ctg(7,5));
            Console.WriteLine("Арксинус" + Trigonometry.ArcSin(7,5));
            Console.WriteLine(" ");
            //Алгебра
            Console.WriteLine("Алгебра");
            Console.WriteLine(" ");
            Console.WriteLine("Корень квадратичного уравнения: " + AlgebraEquation.QuadraticEquation(5,7,2));
            Console.WriteLine("Корень линейного уравнения: " + AlgebraEquation.linearEquation(15,27));
            Console.WriteLine("Сумма из двух чисел " + Algebra.Sum(5, 7));
            Console.WriteLine("Среднее из двух чисел " + Algebra.Avg(5, 7));
            Console.WriteLine("Максимальное из двух чисел " + Algebra.Max(5,7));
            Console.WriteLine(" ");

            Console.ReadKey();
        }
    }
}