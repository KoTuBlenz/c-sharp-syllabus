using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise2.Test
{
    [TestClass]
    public class Exercise2Test
    {
        [TestMethod]
        public void ReturnOddEven_OddNumber_ExpectedStringOddNumber()
        {
            //Arange
            var number = 1;
            //Act
            var result = CheckOddEven.ReturnOddEven(number);
            //Assert
            Assert.AreEqual("Odd number", result);
        }

        [TestMethod]
        public void ReturnOddEven_EvenNumber_ExpectedStringEvenNumber()
        {
            //Arange
            var number = 2;
            //Act
            var result = CheckOddEven.ReturnOddEven(number);
            //Assert
            Assert.AreEqual("Even number", result);
        }
    }
}
