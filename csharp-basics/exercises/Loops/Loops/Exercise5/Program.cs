using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter first word:");
            string word2 = Console.ReadLine();            
            string outPut = word1;
            int numberOfDots = 30 - word1.Length - word2.Length;
            for(int i = 0; i < numberOfDots; i++)
            {
                outPut += ".";
            }
            outPut += word2;
            Console.WriteLine(outPut); 
            Console.ReadKey();
        }
    }
}
