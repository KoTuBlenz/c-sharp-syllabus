﻿using System;
using System.Collections.Generic;

namespace ListExercise8
{
    class Program
    {
        static void Main(string[] args)
        {

            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            Console.Write("List before sort: ");
            Console.WriteLine(string.Join(",", colors));
            colors.Sort();
            Console.Write("List after sort: ");
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
