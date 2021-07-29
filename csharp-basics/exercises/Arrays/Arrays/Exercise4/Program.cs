using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };
            int myArrayLenght = myArray.Length;
            int numberToFind = 0;
            while (true)
            {
                Console.WriteLine("Enter a number and check if the array contains it");
                if (int.TryParse(Console.ReadLine(), out numberToFind))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input is not a number");
                }
            }      
            for (int i = 0; i < myArrayLenght; i++) 
            {

                if (myArray.Contains(numberToFind))
                {
                    Console.WriteLine("Array contains the number!");
                    break;
                }
                if (i == myArrayLenght-1)
                {
                    Console.WriteLine("Array does not contain the number!");
                }
            }
            Console.ReadKey();
            
        }
    }
}
