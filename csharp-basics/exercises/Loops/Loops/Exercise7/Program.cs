using System;

namespace Exercise7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            var rand = new Random();
            int sum = 0;
            while (true)
            { 
                int diceResult = rand.Next(1, 7);
                Console.WriteLine($"You rolled a {diceResult}");
                if (diceResult != 1)
                {                    
                    sum += diceResult;
                    Console.WriteLine("Do you want to roll again? (y/n)");
                    string userInput = Console.ReadLine();                    
                    if (userInput == "n" || userInput == "N")
                    {
                        break;
                    }
                }
                else
                {
                    sum = 0;
                    break;
                }                
            }
            Console.WriteLine($"You got {sum} points");
            Console.ReadKey();
        }
    }
}
