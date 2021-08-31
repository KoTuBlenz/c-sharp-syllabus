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
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckOddEven.ReturnOddEven(number));
            Console.ReadKey();
        }
    }

    public class CheckOddEven
    {
        public static string ReturnOddEven(int number)
        {
            if (number % 2 == 0)
            {
                return "Even number";
            }
            else
            {
                return "Odd number";
            }
        }
    }
}
