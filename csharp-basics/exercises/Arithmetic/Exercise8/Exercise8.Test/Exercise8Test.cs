using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise8.Test
{
    [TestClass]
    public class Exercise8Test
    {
        private SalaryCalculator _target;

        [TestMethod]
        public void IsBasePayTooLow_TooLowBasePay_ExpectedTrue()
        {
            //Arrange
            var basePay = 7.00;
            var hoursWorked = 40;
            _target = new SalaryCalculator(basePay, hoursWorked);
            //Act
            var result = _target.IsBasePayTooLow();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsBasePayTooLow_AcceptableBasePay_ExpectedFalse()
        {
            //Arrange
            var basePay = 8.00;
            var hoursWorked = 40;
            _target = new SalaryCalculator(basePay, hoursWorked);
            //Act
            var result = _target.IsBasePayTooLow();
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void AreWorkedHoursTooMany_TooManyWorkedHours_ExpectedTrue()
        {
            //Arrange
            var basePay = 8.00;
            var hoursWorked = 61;
            _target = new SalaryCalculator(basePay, hoursWorked);
            //Act
            var result = _target.AreWorkedHoursTooMany();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AreWorkedHoursTooMany_AcceptableAmountOfHours_ExpectedTrue()
        {
            //Arrange
            var basePay = 8.00;
            var hoursWorked = 40;
            _target = new SalaryCalculator(basePay, hoursWorked);
            //Act
            var result = _target.AreWorkedHoursTooMany();
            //Assert
            Assert.IsFalse(result);
        }
        [DataTestMethod]
        [DataRow(8.20, 47, "414.10")]
        [DataRow(8.20, 40, "328.00")]
        public void CalculateSalary_AcceptableBasePayAndHours_ExpetedOutputSameAsResult
            (double basePay, int hoursWorked, string expected)
        {
            //Arrange
            _target = new SalaryCalculator(basePay, hoursWorked);
            //Act
            var result = _target.CalculateSalary();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
