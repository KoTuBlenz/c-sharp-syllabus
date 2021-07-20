using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of a day. (Programmers start counting from 0)");
            if(int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                if (dayNumber>6 || dayNumber <0)
                {
                    Console.WriteLine("Not a valid day");
                }
                else
                {
                    switch (dayNumber)
                    {
                        case 0:
                            Console.WriteLine("Sunday");
                            break;
                        case 1:
                            Console.WriteLine("Monday");
                            break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                        default:
                            Console.WriteLine("Not a valid day");           // Tehnically there is no need for a default case, as the only variable,
                            break;                                          // that can be passed to switch case is int from 0 to 6.
                                                                            // So its impossible to access default case
                    }
                }
            }
            else
            {
                Console.WriteLine("Input is not a number");
            }
            Console.ReadKey();
        }
    }
}
