using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"I have lost my number in this array and I need to find it\" program!");
            int[] randArray = FillArray(20, 100);
            DisplayArray(randArray);
            Console.Write("Please enter the number you are looking for: ");
            int userInput = CheckUserInput();
            int indexOfNumber = Array.IndexOf(randArray, userInput);
            if (indexOfNumber < 0)
            {
                Console.WriteLine($"Number |{userInput}| was not found.");
            }
            else
            {
                Console.WriteLine($"Number |{userInput}| is at position {indexOfNumber+1}");
            }
            Console.ReadKey();
        }

        private static void DisplayArray(int [] array) //Displays a given array
        {
            Console.WriteLine("This is the array:\n" +
                "=-=-=-=-=-=--=-=-=--=-=-=-=-=--=-=-=-=-=-=-=");
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("=-=-=-=-=-=--=-=-=--=-=-=-=-=--=-=-=-=-=-=-");
        }

        private static int CheckUserInput() //Checks if users input is correct
        {
            int userInput = 0;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Input is not correct!");
                }
            }
        }
        
        private static int [] FillArray(int arraySize,int maxNumberSize)     // Fills array with random numbers.                                                                  
        {                                                                    // Array size and max random number needs to be defined
            var rand = new Random();
            int [] randArray = new int [arraySize];
            for ( int i=0; i<arraySize; i++)
            {
                randArray[i] = rand.Next(0, maxNumberSize);
            }
            return randArray;
        }       
    }
}
