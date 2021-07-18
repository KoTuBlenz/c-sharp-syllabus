using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence!");
            string sentence = Console.ReadLine();
            int sentenceSize = sentence.Length;
            int numberOfCapitalLetters = 0;
            for(int i = 0; i< sentenceSize; i++)
            {
                if (Char.IsUpper(sentence[i])) numberOfCapitalLetters++;
            }
            Console.WriteLine($"There are {numberOfCapitalLetters} capital leters in this sentence.");
            Console.ReadKey();
        }
    }
}
