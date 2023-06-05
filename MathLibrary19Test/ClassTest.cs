using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathLibrary19;

namespace MathLibrary19Test
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void SReactangleTesta5b4s20()
        {
            //arrange
            double a = 5;
            double b = 4;
            double s = 20;
            //act
            Geometry.SReactangle(a, b);
            //assert
            Assert.AreEqual(s, a*b);
        }

        [TestMethod]
        public void SReactangleTesta3b6s18()
        {
            //arrange
            double a = 3;
            double b = 6;
            double s = 18;
            //act
            Geometry.SReactangle(a, b);
            //assert
            Assert.AreEqual(s, a*b);
        }

        [TestMethod]
        public void SReactangleTesra9b7s63()
        {
            double a = 9;
            double b = 7;
            double s = 63;

            Geometry.SReactangle(a, b);

            Assert.AreEqual(s, a * b);
        }

        [TestMethod]
        public void STriangleTesta3h4s6()
        {
            double a = 3;
            double h = 4;
            double s = 6;
            Geometry.STriangle(a, h);
            Assert.AreEqual(s, 0.5 * (a * h));
        }

        [TestMethod]
        public void STriangleTesta4h8s16()
        {
            double a = 4;
            double h = 8;
            double s = 16;
            Geometry.STriangle(a, h);
            Assert.AreEqual(s, 0.5 * (a * h));
        }

        [TestMethod]
        public void STriangleTesta6h7s21()
        {
            double a = 6;
            double h = 7;
            double s = 21;
            Geometry.STriangle(a, h);
            Assert.AreEqual(s, 0.5 * (a * h));
        }

        [TestMethod]
        public void SReactangleTriangleTesta3b4s6()
        {
            double a = 3;
            double b = 4;
            double s = 6;
            Geometry.SRectangleTriangle(a, b);
            Assert.AreEqual(s, 0.5 * a * b);
        }

        [TestMethod]
        public void SReactangleTriangleTesta4b5s10()
        {
            double a = 4;
            double b = 5;
            double s = 10;
            Geometry.SRectangleTriangle(a, b);
            Assert.AreEqual(s, 0.5 * a * b);
        }

        [TestMethod]
        public void SReactangleTriangleTesta6b6s18()
        {
            double a = 6;
            double b = 6;
            double s = 18;
            Geometry.SRectangleTriangle(a, b);
            Assert.AreEqual(s, 0.5 * a * b);
        }

        [TestMethod]
        public void SCircleTestr5s78()
        {
            double r = 5;
            double s = 78.54;

            Geometry.SCircle(r);
            Assert.AreEqual(s, Math.Round(Math.PI * (Math.Pow(r, 2)), 2));
        }


        [TestMethod]
        public void SCircleTestr7s153()
        {
            double r = 7;
            double s = 153.94;

            Geometry.SCircle(r);
            Assert.AreEqual(s, Math.Round(Math.PI * (Math.Pow(r, 2)), 2));
        }


        [TestMethod]
        public void SCircleTestr10s314()
        {
            double r = 10;
            double s = 314.16;

            Geometry.SCircle(r);
            Assert.AreEqual(s, Math.Round(Math.PI * (Math.Pow(r, 2)), 2));
        }

        [TestMethod]
        public void STrapezoidTesta4b5h6s27()
        {
            double a = 4;
            double b = 5;
            double h = 6;
            double s = 27;
            Geometry.STrapezoid(a, b, s);
            Assert.AreEqual(s, ((a + b) / 2) * h);
        }

        [TestMethod]
        public void STrapezoidTesta5b6h8s44()
        {
            double a = 5;
            double b = 6;
            double h = 8;
            double s = 44;
            Geometry.STrapezoid(a, b, s);
            Assert.AreEqual(s, ((a + b) / 2) * h);
        }

        [TestMethod]
        public void STrapezoidTesta4b5h6s102()
        {
            double a = 8;
            double b = 9;
            double h = 12;
            double s = 102;
            Geometry.STrapezoid(a, b, s);
            Assert.AreEqual(s, ((a + b) / 2) * h);
        }

    }

    [TestClass]
    public class TrigonometryClassTest
    {

        [TestMethod]
        public void SinTesta9b4s2()
        {
            double a = 9;
            double b = 4.5;
            double s = 2;
            Trigonometry.Sin(a, b);
            Assert.AreEqual(s, a/b);
        }

        [TestMethod]
        public void SinTesta30b15s2()
        {
            double a = 30;
            double b = 15;
            double s = 2;
            Trigonometry.Sin(a, b);
            Assert.AreEqual(s, a / b);
        }

        [TestMethod]
        public void SinTesta14b4s3()
        {
            double a = 14;
            double b = 4;
            double s = 3.5;
            Trigonometry.Sin(a, b);
            Assert.AreEqual(s, a / b);
        }

        [TestMethod]
        public void CosTestc14b4s3()
        {
            double c = 14;
            double b = 4;
            double s = 3.5;
            Trigonometry.Cos(c, b);
            Assert.AreEqual(s, c / b);
        }

        [TestMethod]
        public void CosTestc9b45s2()
        {
            double c = 9;
            double b = 4.5;
            double s = 2;
            Trigonometry.Cos(c, b);
            Assert.AreEqual(s, c / b);
        }

        [TestMethod]
        public void CosTestc30b15s2()
        {
            double c = 30;
            double b = 15;
            double s = 2;
            Trigonometry.Cos(c, b);
            Assert.AreEqual(s, c / b);
        }


        [TestMethod]
        public void TgTesta30c15s2()
        {
            double a = 30;
            double c = 15;
            double s = 2;
            Trigonometry.Tg(a, c);
            Assert.AreEqual(s, a / c);
        }

        [TestMethod]
        public void TgTesta14c4s3()
        {
            double a = 14;
            double c = 4;
            double s = 3.5;
            Trigonometry.Tg(a, c);
            Assert.AreEqual(s, a / c);
        }

        [TestMethod]
        public void TgTesta9bc4s2()
        {
            double a = 9;
            double c = 4.5;
            double s = 2;
            Trigonometry.Tg(a, c);
            Assert.AreEqual(s, a / c);
        }

        [TestMethod]
        public void CtgTesta30c15s2()
        {
            double a = 30;
            double c = 15;
            double s = 2;
            Trigonometry.Ctg(a, c);
            Assert.AreEqual(s, a / c);
        }

        [TestMethod]
        public void CtgTesta14c4s3()
        {
            double a = 14;
            double c = 4;
            double s = 3.5;
            Trigonometry.Ctg(a, c);
            Assert.AreEqual(s, a / c);
        }

        [TestMethod]
        public void CtgTesta9bc4s2()
        {
            double a = 9;
            double c = 4.5;
            double s = 2;
            Trigonometry.Ctg(a, c);
            Assert.AreEqual(s, a / c);
        }

        [TestMethod]
        public void ArcSinTesta30b15s2()
        {
            double a = 30;
            double b = 15;
            double s = 2;
            Trigonometry.ArcSin(a, b);
            Assert.AreEqual(s, a / b);
        }

        [TestMethod]
        public void ArcSinTesta14b4s3()
        {
            double a = 14;
            double b = 4;
            double s = 3.5;
            Trigonometry.ArcSin(a, b);
            Assert.AreEqual(s, a / b);
        }

        [TestMethod]
        public void ArcSinTesta9b4s2()
        {
            double a = 9;
            double b = 4.5;
            double s = 2;
            Trigonometry.ArcSin(a, b);
            Assert.AreEqual(s, a / b);
        }


    }


}
