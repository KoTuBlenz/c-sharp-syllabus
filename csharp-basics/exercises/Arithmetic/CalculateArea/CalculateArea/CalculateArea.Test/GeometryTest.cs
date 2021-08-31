using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculateArea.Test
{
    [TestClass]
    public class GeometryTest
    {
        [DataTestMethod]
        [DataRow(10.00, 62.8319)]
        [DataRow(20.00, 125.6637)]
        public void AreaOfCircle_DifferentRadiuses_ExpectedOutputSameAsResult(double radius, double expected)
        {
            //arrange
            var Radius = Convert.ToDecimal(radius);
            //Act
            var result = Geometry.AreaOfCircle(Radius);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(10.00, 10.00, 100.0000)]
        [DataRow(25.00, 15.00, 375.0000)]
        public void AreaOfRectangle_DifferentLenghtWidth_ExpectedOutputSameAsResult(double length,double width, double expected)
        {
            //arrange
            var Length = Convert.ToDecimal(length);
            var Width = Convert.ToDecimal(width);
            //Act
            var result = Geometry.AreaOfRectangle(Length, Width);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(10.00, 10.00, 50.0000)]
        [DataRow(25.00, 15.00, 187.5000)]
        public void AreaOfTriangle_DifferentGroundHeight_ExpectedOutputSameAsResult(double ground, double height, double expected)
        {
            //arrange
            var Ground = Convert.ToDecimal(ground);
            var Height = Convert.ToDecimal(height);
            //Act
            var result = Geometry.AreaOfTriangle(Ground, Height);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
