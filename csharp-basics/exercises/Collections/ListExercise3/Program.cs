using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine("List 1:\n"+string.Join(", ", colors));
            colors.Insert(0, "Purple");
            colors.Insert(3, "Blue");
            Console.WriteLine("List 2:\n"+string.Join(", ", colors));
            Console.ReadKey();
        }
    }
}
