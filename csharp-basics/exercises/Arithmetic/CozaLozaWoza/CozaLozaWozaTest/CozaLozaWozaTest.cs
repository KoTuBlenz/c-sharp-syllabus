using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CozaLozaWoza.Test
{
    [TestClass]
    public class CozaLozaWozaTest
    {

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_Number3_ExpectedStringCoza()
        {
            // Arrange
            var number = 3;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("Coza", result);
        }

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_Number5_ExpectedStringLoza()
        {
            // Arrange
            var number = 5;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("Loza", result);
        }

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_Number7_ExpectedStringWoza()
        {
            // Arrange
            var number = 7;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("Woza", result);
        }

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_MultipleOf3And5_ExpectedStringCozaLoza()
        {
            // Arrange
            var number = 15;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("CozaLoza", result);
        }

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_MultipleOf3And7_ExpectedStringCozaWoza()
        {
            // Arrange
            var number = 21;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("CozaWoza", result);
        }

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_MultipleOf5And7_ExpectedStringLozaWoza()
        {
            // Arrange
            var number = 35;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("LozaWoza", result);
        }

        [TestMethod]
        public void CheckNumberForCozaLozaWoza_Number2_ExpectedSameNumber()
        {
            // Arrange
            var number = 2;
            //Act
            var result = CozaLozaWoza.CheckNumber(number);
            //Assert
            Assert.AreEqual("2", result);
        }
    }
}
