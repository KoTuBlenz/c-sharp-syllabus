using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneKeyPad
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter text without numbers to convert it to phone keypad digits");

            string textLower = Console.ReadLine().ToLower();
            if (textLower.Length > 0)
            {
                if (!textLower.Any(Char.IsDigit))   //Checks if text contains a number
                {
                    string answer = "";
                    foreach (char letter in textLower)
                    {
                        answer += charToDigit(letter);
                    }
                    Console.WriteLine(answer);
                }
                else
                {
                    Console.WriteLine("Text contains numbers");
                }
            }
            else
            {
                Console.WriteLine("Input is empty");
            }
            
            Console.ReadKey();
        }
        
        public static string charToDigit(char textChar) //Converts a charecter to a number on the keypad
        {
            switch (textChar)
            {
                case 'a':
                case 'b':
                case 'c':
                    return "2";

                case 'd':
                case 'e':
                case 'f':
                    return "3";

                case 'g':
                case 'h':
                case 'i':
                    return "4";

                case 'j':
                case 'k':
                case 'l':
                    return "5";

                case 'm':
                case 'n':
                case 'o':
                    return "6";

                case 'p':
                case 'q':
                case 'r':
                case 's':
                    return "7";

                case 't':
                case 'u':
                case 'v':
                    return "8";

                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    return "9";

                case ' ':
                    return "|0|";

                default:            //Most of the special symbols are on 1 for the most phones
                    return "1";
            }
        }
    }
}
