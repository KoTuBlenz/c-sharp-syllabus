using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benson = new Account("Benson", 17.50);
            Account maggie = new Account("Maggie", 0);
            Account bob = new Account("Bob", -0.35);

            Console.WriteLine(benson.ShowUserNameAndBalance());
            Console.WriteLine(maggie.ShowUserNameAndBalance());
            Console.WriteLine(bob.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
    
}
