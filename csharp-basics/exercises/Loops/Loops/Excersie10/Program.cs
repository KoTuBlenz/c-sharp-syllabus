using System;

namespace Excersie10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Min?:");
            int min = CheckUserInput();            
            Console.Write("Max?:");
            int max = CheckUserInput();            
            DrawNumberSquare(min, max);
            Console.ReadKey();
        }
        private static void DrawNumberSquare(int min, int max)  //Draws number square based on min and max value
        {                                                       //Numbers in the square wrap around
            for(int i=0; i<=max-min; i++)
            {
                int[] numArr = new int[max - min+1];
                for (int n=min; n<=max; n++)
                {
                    int num = n + i;
                    if (num > max)  //Wraps the numbers around
                    {
                        num = num - max + min - 1;
                    }
                    numArr[n-min]=num;
                }
                Console.WriteLine(String.Join("|",numArr));     //Prints numbers joined with "|" for better readability
            }
        }
        private static int CheckUserInput()     //Checks if users input is corrct
        {
            int userInput = 0;
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
    }
}
