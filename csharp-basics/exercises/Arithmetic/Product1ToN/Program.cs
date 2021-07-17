using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product1ToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number N");
            int.TryParse(Console.ReadLine(), out int number);
            int factorialNumber=1;
            for (int i=1; i<=number; i++)
            {
                factorialNumber *= i;
            }
            Console.WriteLine($"The factorial of number {number} is {factorialNumber}");
            Console.ReadKey();
        }
    }
}
