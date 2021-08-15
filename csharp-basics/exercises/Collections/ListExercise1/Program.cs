using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>();
            var myBucketList = new List<string>() {"Jump with a parachute","Enjoy zero gravity","Finish Codelex courses"};

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");
            colors.Add("Orange");
            foreach(string idea in myBucketList)
            {
                Console.WriteLine(idea);
            }
            Console.WriteLine();

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
    }
}
