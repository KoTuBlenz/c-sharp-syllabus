using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            int birthYear;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("What is your birth year?");
            Int32.TryParse(Console.ReadLine(), out birthYear);
            Console.WriteLine($"My name is {name} and I was born in {birthYear}.");
            Console.ReadKey();
        }
    }
}
