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
            for (int i = 1; i <= 110; i++)
            {              
                string answer = "";
                if (i % 3 == 0)
                {
                    answer += "Coza";
                }

                if (i % 5 == 0)
                {
                    answer += "Loza";
                }

                if (i % 7 == 0)
                {
                    answer += "Woza";
                }

                if (answer != "")
                {
                    Console.Write(answer);
                }
                else
                {
                    Console.Write(i);
                }

                if (i % 11 == 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.ReadKey();
        }
    }
}
