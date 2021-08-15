using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomList = new HashSet<string>() { "Apple", "Pineapple", "Cybertruck", "MacBook", "Android" };
            Console.WriteLine("List with 5 items");
            foreach(string thing in randomList)
            {
                Console.WriteLine(thing);
            }
            randomList.Clear();
            randomList.Add("Mac and cheese");
            randomList.Add("Mac and cheese");
            Console.WriteLine("\nList with duplicate items");
            foreach (string thing in randomList)
            {
                Console.WriteLine(thing);
            }
            Console.ReadKey();
        }
    }
}
