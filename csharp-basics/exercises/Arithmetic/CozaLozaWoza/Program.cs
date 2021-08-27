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
           // var target = new CozaLozaWoza();
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
            //var cozaLozaWoza = new CozaLozaWoza(110);
            //cozaLozaWoza.DisplayCozaLozaWoza();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    public class CozaLozaWoza
    {
        //private string _cozaLozaWozaString;

        //public CozaLozaWoza(int number)
        //{
        //    for (int i = 1; i<=number; i++)
        //    {
        //        _cozaLozaWozaString += CheckNumberForCozaLozaWoza(i);
        //        if (i % 11 == 0)
        //        {
        //            _cozaLozaWozaString += "\n";
        //        }
        //        else
        //        {
        //            _cozaLozaWozaString += " ";
        //        }
        //    }
        //}
        //public CozaLozaWoza() { }

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

        //public void DisplayCozaLozaWoza()
        //{
        //    Console.WriteLine(_cozaLozaWozaString);
        //}
    }
}
