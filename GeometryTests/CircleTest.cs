using Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GeometryTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double radius = 5;
            double expectedArea = Math.PI * radius * radius;
            Circle circle = new Circle(radius);

            double actualArea = circle.CalculateArea();

            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }
    }
}
