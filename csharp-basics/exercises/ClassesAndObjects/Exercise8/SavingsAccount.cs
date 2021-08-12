using System;
namespace Exercise8
{
    class SavingsAccount
    {
        private double _balance;
        private double _monthlyInterestRate;
        private double _interestEarned;
        private double _totalAmountDeposited;
        private double _totalAmountWithdrawn;
        public SavingsAccount(double startingBalance, double annualInterestRate)
        {
            _balance = startingBalance;
            _monthlyInterestRate = annualInterestRate/12;
        }
        public void Withdrawn(double amountWithdrawn)
        {
            _totalAmountWithdrawn += amountWithdrawn;  
            _balance -= amountWithdrawn;
        }
        public void Deposit(double amountOfDeposit)
        {
            _totalAmountDeposited += amountOfDeposit;
            _balance += amountOfDeposit;
        }
        public void MonthlyInterest()
        {
        _interestEarned += _balance * _monthlyInterestRate;
            _balance += _balance * _monthlyInterestRate;
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Ending balance is: {String.Format("{0:n}", _balance)}");
        }
        public void PrintInterestEarned()
        {
            Console.WriteLine($"Interest earned is: {String.Format("{0:n}", _interestEarned)}");
        }
        public void PrintTotalAmountDeposited()
        {
            Console.WriteLine($"Total amount deposited is: {String.Format("{0:n}", _totalAmountDeposited)}");
        }
        public void PrintTotalAmountWithdrawn()
        {
            Console.WriteLine($"Total amount withdrawn is: {String.Format("{0:n}", _totalAmountWithdrawn)}");
        }
    }
}
