using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mattAccount = new Account("Matt's account", 1000);
            var myAccount = new Account("My account",0);
            mattAccount.withdrawal(100);
            myAccount.deposit(100);
            Console.WriteLine(mattAccount);
            Console.WriteLine(myAccount);

            var aAccount = new Account("A account", 100.00);
            var bAccount = new Account("B account",0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("Initial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount,cAccount, 25.0);
            
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}
