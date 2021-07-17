using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer #1");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.WriteLine("Enter integer #2");
            int.TryParse(Console.ReadLine(), out int number2);
            if (number1 == 15 || number2 == 15) Console.WriteLine("True");
            else if (number1 + number2 == 15) Console.WriteLine("True");
            else if (number1 - number2 == 15 || number2 - number1 == 15) Console.WriteLine("True");
            else Console.WriteLine("False");
            Console.ReadKey();


        }
    }
}
