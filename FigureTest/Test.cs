using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using System;

namespace Task
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestTriangleArea()
        {
            int expected = 6;

            double result = Math.Round(Figure.CalculateArea(3, 4, 5));

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestCircleArea()
        {
            int expected = 63;

            double result = Math.Round(Figure.CalculateArea(10));

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestTriangleRightAngle() => Assert.IsTrue(Figure.TriangleRightAngle(3, 4, 5));
    }
}