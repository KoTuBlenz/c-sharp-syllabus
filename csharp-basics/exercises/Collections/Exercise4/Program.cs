using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a integer:");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            while (true)
            {
                int sum=0;
                foreach(char digit in numberString)
                {
                    int num = int.Parse(digit.ToString());
                    sum += num*num;
                }
                if (sum == 1)
                {
                    Console.WriteLine("Number is happy! :)");
                    break;
                }
                else if (sum == 4)
                {
                    Console.WriteLine("Number is not happy! :(");
                    break;
                }
                numberString = sum.ToString();
            }
            Console.ReadKey();
        }
    }
}
