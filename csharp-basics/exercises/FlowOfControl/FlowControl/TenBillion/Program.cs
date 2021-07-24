using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            if (long.TryParse(Console.ReadLine(), out long n))
            {
                if (n < 0)
                {
                    n *= -1;
                }
                int nLenght = n.ToString().Length;
                if (nLenght > 10)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");

                }
                else 
                { 
                    Console.WriteLine("Number of digits in the number: " + nLenght); 
                }
            }
            else
            {
                Console.WriteLine("Input is not a number!");
            }
            Console.ReadKey();
          

        }
    }
}
