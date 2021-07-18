using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number of minutes! Press any letter to end program.");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int minutes))
                {
                    int years = (int)(minutes / 525948.766);
                    int days = (int)(minutes % 525948.766) / 1440;
                    Console.WriteLine($"In {minutes} minutes, there are {years} years and {days} days.");
                    Console.WriteLine("Continue, or press any letter to end program.");
                }
                else break;
            }
        }
    }
}
