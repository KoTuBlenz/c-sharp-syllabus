using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../lear.txt";
            Console.WriteLine("Lines in text: "+LinesInText(path));
            Console.WriteLine("Words in text: " + WordsInText(path));
            Console.WriteLine("Chars in text: " + CharsInText(path));
            Console.ReadKey();
        }

        public static int LinesInText(string path)
        {
            return File.ReadAllLines(path).Length;
        }

        public static int WordsInText(string path)
        {
            return File.ReadAllText(path).Replace("'", " ").Replace("  ", " ").Split(' ', '\n').Length;
        }

        public static int CharsInText(string path)
        {
            return File.ReadAllText(path).Replace("\n","").ToCharArray().Length;
        }
    }
}
