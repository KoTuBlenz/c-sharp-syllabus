using System;
using System.Collections.Generic;
using System.IO;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";
        private static SortedDictionary<int,int>ScoreSortedList = new SortedDictionary<int, int>();
        private static void Main(string[] args)
        {
            var readText = File.ReadAllText(Path).Split(' ');
            //Fills sorted dictionary with keys from 0 to 10 with 0 value
            for (int i = 0; i<11; i++)
            {
                ScoreSortedList.Add(i,0);
            }
            //Divides every number by 10, rounds it down and then increases the keys value by 1
            foreach (var s in readText)
            {
                int num = int.Parse(s);
                int key = num / 10;
                ScoreSortedList[key]++;
            }
            foreach(KeyValuePair<int,int> kvp in ScoreSortedList)
            {
                if (kvp.Key == 10)
                {
                    Console.WriteLine($"  {string.Format("{0:00}", kvp.Key * 10)}: {new string('*', kvp.Value)}");
                }
                else
                {
                    Console.WriteLine($"{string.Format("{0:00}", kvp.Key * 10)}-{string.Format("{0:00}", (kvp.Key * 10) + 9)}: {new string('*', kvp.Value)}");
                }
            }
            Console.ReadKey();
        }
    }
}
