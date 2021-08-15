using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            Console.WriteLine("First list: "+string.Join(",", firstList));
            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            Console.WriteLine("Second list: " + string.Join(",", secondList));
            var joinedList = new List<string>();
            joinedList = firstList.Concat(secondList).ToList();
            Console.WriteLine("Joined list: " + string.Join(",", joinedList));
            Console.ReadKey();
        }
    }
}
