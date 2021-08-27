using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../lear.txt";
            var text = new TextProperties(File.ReadAllText(path));
            Console.WriteLine("Lines in text: "+ text.LinesInText());
            Console.WriteLine("Words in text: " + text.WordsInText());
            Console.WriteLine("Chars in text: " + text.CharsInText());
            Console.ReadKey();
        }
    }

    public class TextProperties
    {
        private string _text;

        public TextProperties(string text)
        {
            _text = text;
        }

        public int LinesInText()
        {
            return _text.Split('\n').Length;
        }

        public int WordsInText()
        {
            return _text.Replace("'", " ").Replace("  ", " ").Split(' ', '\n').Length;
        }

        public int CharsInText()
        {
            return _text.Replace("\n", "").ToCharArray().Length;
        }
    }
}
