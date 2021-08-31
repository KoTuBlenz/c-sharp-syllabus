using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Test
{
    [TestClass]
    public class TeslaTest
    {
        private ICar _target;

        [TestMethod]
        public void SpeedUp_SpeedupTwice_ExpectedCurrentSpeedEqualDoubleSpeedUpSpeed()
        {
            //Arrange
            _target = new Tesla();
            var expected = "34";
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
            _target = new Tesla();
            var expected = "-27";
            //Act
            _target.SlowDown();
            var result = _target.CurrentSpeed;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
   
}
