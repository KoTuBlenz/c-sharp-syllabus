using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DragRace.Test
{
    [TestClass]
    public class AudiTest
    {
        private ICar _target;

        [TestMethod]
        public void SpeedUp_SpeedupTwice_ExpectedCurrentSpeedEqualDoubleSpeedUpSpeed()
        {
            //Arrange
            _target = new Audi();
            var expected = "28";
            //Act
            _target.SpeedUp();
            _target.SpeedUp();
            var result = _target.CurrentSpeed;
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void SlowDown_SlowDownOnce_ExpectedCurrentSpeedMinusSlowDown()
        {
            //Arrange
            _target = new Audi();
            var expected = "-20";
            //Act
            _target.SlowDown();
            var result = _target.CurrentSpeed;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
