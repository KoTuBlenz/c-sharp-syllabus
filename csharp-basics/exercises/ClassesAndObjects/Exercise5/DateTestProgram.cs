using System;

namespace Exercise5
{
    class DateTestProgram
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(3,3,2001);
            Console.WriteLine(date1.ToString());
            Date date2 = new Date(32, 1, 2000);
            Console.WriteLine(date2.ToString());
            Date date3 = new Date(13,13,13);
            Console.WriteLine(date3.ToString());
            Date date4 = new Date(29, 04, 2009);
            Console.WriteLine(date4.ToString());
            Console.WriteLine($"In year {date4.year} there were {date4.day} days in {date4.month} month");
            Console.ReadKey();
        }
    }
}
