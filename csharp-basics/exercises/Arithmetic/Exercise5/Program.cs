using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            var rnd = new Random();
            int randomNumber = rnd.Next(1, 100);
            int.TryParse(Console.ReadLine(), out int numberGuessed);
            string answer = "";
            if (numberGuessed == randomNumber)
            {
                answer = "You guessed it!  What are the odds?!?";
            }
            else if (numberGuessed > randomNumber)
            {
                answer = $"Sorry, you are too high.  I was thinking of {randomNumber}";
            }
            else
            {
                answer = $"Sorry, you are too low.  I was thinking of {randomNumber}";
            }
            Console.WriteLine(answer);
            Console.ReadKey();

        }
    }
}
