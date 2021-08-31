using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer #1");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter integer #2");
            var second = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckNumbers.IsThere15(first, second));
            Console.ReadKey();
        }
    }
    public class CheckNumbers
    {
        //Returns true, if one of the given numbers is 15 or their sum or difference is 15
        public static bool IsThere15( int first, int second)
        {
            int difference = first - second > 0 ? first - second : (first - second) * -1;
            if (first == 15 || second == 15 ||
                first + second == 15 ||
                difference==15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
