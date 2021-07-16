using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfNumbers=0;
            Console.WriteLine("Write a number to add, or press (N) to see result!");
            while (true)             
            {
                string keyPressed = Console.ReadLine();
                if (keyPressed == "N" || keyPressed == "n") break;
                if (int.TryParse(keyPressed, out int number)) sumOfNumbers+=number;
            }
            Console.WriteLine(sumOfNumbers);
            Console.ReadKey();
        }
    }
}
