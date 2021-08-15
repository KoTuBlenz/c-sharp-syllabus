using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            while (true)
            {
                Console.Write("Enter name:");
                string name = Console.ReadLine();
                if (name == "") break;
                names.Add(name);
            }
            Console.WriteLine($"Unique name list contains: {String.Join(" ",names)}");
            Console.ReadKey();
        }
    }
}
