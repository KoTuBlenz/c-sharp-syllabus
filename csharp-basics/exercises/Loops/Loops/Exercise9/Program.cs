using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.Write("Enter desired sum (2-12):");
            var rand = new Random();
            int desirableSum;
            while (true)        //Checks users input
            {
                if (int.TryParse(Console.ReadLine(), out desirableSum))                   
                {
                    if (desirableSum > 12 || desirableSum < 0)
                    {
                        Console.WriteLine("Incorrect input");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            while (true) // Sums 2 random numbers till the desirable sum is reached
            {
                int roll1 = rand.Next(1, 7);
                int roll2 = rand.Next(1, 7);
                int rollSum = roll1 + roll2;
                Console.WriteLine($"{roll1} and {roll2} = {rollSum}");
                if (rollSum == desirableSum)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
