using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GravityCalculator.Test
{
    [TestClass]
    public class GravityCalculatorTest
    {
        [DataTestMethod]
        [DataRow(-9.81, 0, 10.0 ,0, -490.5)]
        [DataRow(-9.81, 0, 10.0, 10, -480.5)]
        [DataRow(-9.81, 20.0, 10.0, 0, -290.5)]
        [DataRow(-5.0, 0.0, 10.0, 0, -250)]

        public void CalculateFinalPosition_DifferentVarialbes_ExpetedOutputIsReturned
            (double gravity, double initialVelocity, double fallingTime, double initialPosition, double expected)
        {
            //Act
            var result = GravityCalculator.CalculateFinalPosition(gravity, initialVelocity, fallingTime, initialPosition);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
