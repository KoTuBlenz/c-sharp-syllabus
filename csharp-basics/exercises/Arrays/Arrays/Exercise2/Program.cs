using System;


namespace Exercise2
{
    class Program
    {       
        //TODO: Write a C# program to sum values of an array.
        private static void Main(string[] args)
        {            
            var sum = 0;
            int minNumber;
            int maxNumber;
           while (true)
            {
                Console.WriteLine("Please enter a min number ");
               if(int.TryParse(Console.ReadLine(), out minNumber))
               {                  
                        break;               
               }
               else
               {
                    Console.WriteLine("Input is not a number");
               }
            }
            while (true)
            {
                Console.WriteLine("Please enter a max number ");
                if (int.TryParse(Console.ReadLine(), out maxNumber))
                { 
                    if (maxNumber>=minNumber)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Max number cannot be smaller than min number");
                    }
                }
                else
                {
                    Console.WriteLine("Input is not a number");
                }
            }
            int[] myArray = new int[maxNumber - minNumber + 1];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + minNumber;
                sum += myArray[i];
            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }        
    
    }
}
