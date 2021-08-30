using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "";
            for (int i = 1; i <= 110; i++)
            {
                result += CozaLozaWoza.CheckNumber(i);
                if (i % 11 == 0)
                {
                    result += "\n";
                }
                else
                {
                    result += " ";
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    public class CozaLozaWoza
    {
        public static string CheckNumber(int number)
        {
            string answer = "";
            if (number % 3 == 0)
            {
                answer += "Coza";
            }

            if (number % 5 == 0)
            {
                answer += "Loza";
            }

            if (number % 7 == 0)
            {
                answer += "Woza";
            }

            if (answer.Length == 0)
            {
                answer = number.ToString();
            }
            return answer;
        }
    }
}
