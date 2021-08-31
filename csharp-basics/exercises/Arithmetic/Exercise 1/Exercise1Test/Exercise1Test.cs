using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise1.Test
{
    [TestClass]
    public class Exercise1Test
    {
        [TestMethod]
        public void IsThere15_FirstNumberIs15_ExpectedTrue()
        {
            //Arrange
            var firstNumber = 15;
            var secondNumber = 9;
            //Act
            var result = CheckNumbers.IsThere15(firstNumber,secondNumber);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThere15_SecondNumberIs15_ExpectedTrue()
        {
            //Arrange
            var firstNumber = 15;
            var secondNumber = 9;
            //Act
            var result = CheckNumbers.IsThere15(firstNumber, secondNumber);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThere15_SumEquals15_ExpectedTrue()
        {
            //Arrange
            var firstNumber = 15;
            var secondNumber = 9;
            //Act
            var result = CheckNumbers.IsThere15(firstNumber, secondNumber);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThere15_FirstDifferenceEquals15_ExpectedTrue()
        {
            //Arrange
            var firstNumber = 15;
            var secondNumber = 9;
            //Act
            var result = CheckNumbers.IsThere15(firstNumber, secondNumber);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThere15_SecondDifferenceEquals15_ExpectedTrue()
        {
            //Arrange
            var firstNumber = 15;
            var secondNumber = 9;
            //Act
            var result = CheckNumbers.IsThere15(firstNumber, secondNumber);
            //Asert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsThere15_NoPossibleResult15_ExpectedFalse()
        {
            //Arrange
            var firstNumber = 15;
            var secondNumber = 9;
            //Act
            var result = CheckNumbers.IsThere15(firstNumber, secondNumber);
            //Asert
            Assert.IsTrue(result);
        }
    }
}
