using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void CalculateAreaTest()
        {
            
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = Math.Sqrt((a + b + c) * (a + b - c) * (a - b + c) * (-a + b + c)) / 4;
            Triangle triangle = new Triangle(a, b, c);
            
            double actualArea = triangle.CalculateArea();
         
            Assert.AreEqual(expectedArea, actualArea, 0.001);
        }

        [TestMethod()]
        public void RightTriangleDetection()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);

            bool isRightTriangle = triangle.IsRightTriangle(a,b,c);

            Assert.IsTrue(isRightTriangle);
        }
    }
}