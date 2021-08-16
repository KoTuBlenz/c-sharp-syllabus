using System;

namespace Exercise5
{
    class DateTest
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(3,3,2001);
            date1.PrintDate();
            Date date2 = new Date(32, 1, 2000);
            date2.PrintDate();
            Date date3 = new Date(13,13,13);
            date3.PrintDate();
            Date date4 = new Date(29, 04, 2009);
            date4.PrintDate();
            Console.WriteLine($"In year {date4.year} there were {date4.day} days in {date4.month} month");
            Console.ReadKey();
        }
    }
}
