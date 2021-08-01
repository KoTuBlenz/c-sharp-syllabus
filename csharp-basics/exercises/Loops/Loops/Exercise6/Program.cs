using System;

namespace Exercise6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter max number:");
            int userInput = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            Console.WriteLine();
            for (int i = 1; i <= userInput; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if(i%5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i);
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
