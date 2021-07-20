using System;

namespace LargestNumber
{
    class Program
    {
        //TODO: Write a C# program to to find the largest of three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");           
            int.TryParse(Console.ReadLine(), out int input1);

            Console.WriteLine("Input the 2nd number: ");            
            int.TryParse(Console.ReadLine(), out int input2);

            Console.WriteLine("Input the 3rd number: ");           
            int.TryParse(Console.ReadLine(), out int input3);

            double largestNumber = input1;

            if (input2 > largestNumber)
            {
                largestNumber = input2;
            }
            if (input3 > largestNumber)
            {
                largestNumber = input3;
            }
            Console.WriteLine($"The largest number is {largestNumber}") ;
            Console.ReadKey();

        }
    }
}
