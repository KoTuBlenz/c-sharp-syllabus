using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Account.Test
{
    [TestClass]
    public class AccountTest
    {
        private Account _target;

        [DataTestMethod]
        [DataRow(10, 5, 15)]
        [DataRow(0, 7, 7)]
        [DataRow(-10, 5, -5)]
        public void Deposit_StartingMoneyDepositedMoney_ExpectedSumOfBoth
            ( double startingMoney, double depositedAmount, double expected )
        {
            //Arrange
            _target = new Account("name", startingMoney);
            //Act
            _target.Deposit(depositedAmount);
            var result = _target.Balance;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(0, 7, -7)]
        [DataRow(-10, 5, -15)]
        public void Withdrawal_StartingMoneyAndMoneyToWithdraw_ExpectedDifference
            (double startingMoney, double withdrawAmount, double expected)
        {
            //Arrange
            _target = new Account("name", startingMoney);
            //Act
            _target.Withdrawal(withdrawAmount);
            var result = _target.Balance;
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Transfer_50Transfered_ExpectedAccount1Removed50Account2Added50()
        {
            //Arrange
            var account1 = new Account("name1", 100);
            var account2 = new Account("name2", 100);
            double transferAmount = 50;
            var expected1 = account1.Balance - transferAmount;
            var expected2 = account2.Balance + transferAmount;
            //Act
            Account.Transfer(account1, account2, transferAmount);
            var result1 = account1.Balance;
            var result2 = account2.Balance;
            //Assert
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod]
        public void ToString_AccountWithNameAndBalance_ExpectedAccountSameNameAndBalanceToString()
        {
            //Arrange
            _target= new Account("name1", 100);;
            var expected = "name1: 100";
            //Act
            var result = _target.ToString();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
