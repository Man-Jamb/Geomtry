using Microsoft.VisualStudio.TestTools.UnitTesting;
using Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void Square_3and4and5_6Returned()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);
            const double expected = 6;

            //act
            double actual = triangle.Square();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsRight_3and4and5_TrueReturned()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);
            const bool expected = true;

            //act
            bool actual = triangle.IsRight();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void Square_5_78Returned()
        {
            //arrange
            Circle circle = new Circle(5);
            const double expected = 78.54;
            const double delta = 0.005;

            //act
            double actual = circle.Square();

            //assert
            Assert.AreEqual(expected, actual, delta);
        }
    }
}


