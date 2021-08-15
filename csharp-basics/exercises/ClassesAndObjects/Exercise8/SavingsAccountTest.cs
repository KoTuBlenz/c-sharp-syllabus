using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            double startingBalance = double.Parse(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            double annualInterestsRate = double.Parse(Console.ReadLine());
            SavingsAccount savingsAccount1 = new SavingsAccount(startingBalance, annualInterestsRate);
            Console.Write("How long has the account been opened?: ");
            int months = int.Parse(Console.ReadLine());
            for (int i = 1; i <= months; i++)
            {
                Console.Write($"Enter amount deposited for month {i}:");
                savingsAccount1.Deposit(double.Parse(Console.ReadLine()));
                Console.Write($"Enter amount withdrawn for month {i}:");
                savingsAccount1.Withdrawn(double.Parse(Console.ReadLine()));
                savingsAccount1.MonthlyInterest();
            }
            Console.WriteLine();
            savingsAccount1.PrintTotalAmountDeposited();
            savingsAccount1.PrintTotalAmountWithdrawn();
            savingsAccount1.PrintInterestEarned();
            savingsAccount1.PrintBalance();
            Console.ReadKey();
        }
    }
}
