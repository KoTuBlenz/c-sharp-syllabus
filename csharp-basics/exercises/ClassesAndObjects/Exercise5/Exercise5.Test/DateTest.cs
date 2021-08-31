using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise5.Test
{
    [TestClass]
    public class DateTest
    {
        private Date _target;
        [TestMethod]
        public void ToString_Date_ExpectedStringOfSameDate()
        {
            //Arrange
            _target = new Date(1, 1, 1111);
            //Act
            var result = _target.ToString();
            var expected = "01/01/1111";
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_DateWithTooManyDays_ExpectedErrorDateIsNotCorrect()
        {
            //Arrange
            _target = new Date(32, 1, 1111);
            //Act
            var result = _target.ToString();
            var expected = "Date is not correct";
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ToString_DateWithToManyMonths_ExpectedErrorDateIsNotCorrect()
        {
            //Arrange
            _target = new Date(1, 13, 1111);
            //Act
            var result = _target.ToString();
            var expected = "Date is not correct";
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
