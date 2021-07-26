using System;
namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            int numberArrayLenght =numbers.Length;
           
            int sum = 0;
            for (int i= 0; i< numberArrayLenght; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            double average = (double)sum / (double)numberArrayLenght;

            Console.WriteLine("Average value of the array elements is : " + String.Format("{0:0.00}",average));
            Console.ReadKey();
        }
    }
}
