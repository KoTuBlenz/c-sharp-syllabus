using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = new int[10];
            int arrayLenght = myArray1.Length;
            var rand = new Random();            
            for (int i=0; i < arrayLenght; i++)
            {
                myArray1[i] = rand.Next(0, 100);
            }
            int[] myArray2 = new int [arrayLenght];
            Array.Copy(myArray1,myArray2, arrayLenght);
            myArray1[arrayLenght - 1] = -7;

            Console.WriteLine($"Array1 = {String.Join(" ", myArray1)}");
            Console.WriteLine($"Array2 = {String.Join(" ", myArray2)}");
            Console.ReadKey();
        }
    }
}
