using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!");
            int.TryParse(Console.ReadLine(), out int number);

            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

            Console.ReadKey();
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
