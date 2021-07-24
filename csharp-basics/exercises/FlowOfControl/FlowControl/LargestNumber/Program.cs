using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            int[] input = new int[3];
            double largestNumber = 0;
            for (int i = 0; i < 3;)
            {
                Console.WriteLine($"Input the number {i+1}");
                if (int.TryParse(Console.ReadLine(), out input[i]))
                {
                    if (input[i]>largestNumber)
                    {
                        largestNumber = input[i];
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Input is not a number. Try again");
                }
            }
            Console.WriteLine($"The largest number is {largestNumber}") ;
            Console.ReadKey();

        }
    }
}
