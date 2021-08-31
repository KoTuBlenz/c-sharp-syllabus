using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DragRace.Test
{
    [TestClass]
    public class VolvoTest
    {
        private ICar _target;
        private ICarBoost _boostTarget;

        [TestMethod]
        public void SpeedUp_SpeedupTwice_ExpectedCurrentSpeedEqualDoubleSpeedUpSpeed()
        {
            //Arrange
            _target = new Volvo();
            var expected = "24";
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
            _target = new Volvo();
            var expected = "-22";
            //Act
            _target.SlowDown();
            var result = _target.CurrentSpeed;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_BoostOnce_ExpectedCurrentSpeedEqualBoost()
        {
            //Arrange
            _boostTarget = new Volvo();
            var expected = "10";
            //Act
            _boostTarget.UseNitrousOxideEngine();
            var result = _boostTarget.CurrentSpeed;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
