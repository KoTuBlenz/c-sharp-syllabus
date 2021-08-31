using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Exercise1.Test
{
    [TestClass]
    public class Exercise1Test
    {
        private Product _target = new Product("name", 0.00, 0);

        [DataTestMethod]
        [DataRow(10.00, 10.00)]
        [DataRow(15.00, 15.00)]
        [DataRow(4.00, 4.00)]
        public void ChangePrice_NewPrice_ExpectedPriceChange(double newPrice, double expected)
        {
            //Act
            _target.ChangePrice(newPrice);
            var result = _target.Price;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(5, 5)]
        [DataRow(3, 3)]
        [DataRow(2, 2)]
        public void ChangeAmount_NewAmount_ExpectedAmountChange(int newAmount, int expected)
        {
            //Act
            _target.ChangeAmount(newAmount);
            var result = _target.Amount;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
