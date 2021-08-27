using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mattAccount = new Account("Matt's account", 1000);
            var myAccount = new Account("My account",0);
            mattAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattAccount);
            Console.WriteLine(myAccount);

            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account",0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Account.Transfer(aAccount,bAccount, 50.0);
            Account.Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }
    }
}
