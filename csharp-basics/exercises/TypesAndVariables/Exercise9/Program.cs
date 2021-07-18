using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in meters");
            int.TryParse(Console.ReadLine(), out int meters);            
            Console.WriteLine("Input hours");
            int.TryParse(Console.ReadLine(), out int hours);     
            Console.WriteLine("Input minutes");
            int.TryParse(Console.ReadLine(), out int minutes);          
            Console.WriteLine("Input seconds");
            int.TryParse(Console.ReadLine(), out int seconds);         
            double sumOfSeconds = (hours * 3600) + (minutes * 60) + seconds;
            double metersPerSecond = meters / sumOfSeconds;
            double kilometersPerHour = (meters / 1000.0) / (sumOfSeconds / 3600.0);
            double milesPerHour = (meters / 1609.0) / (sumOfSeconds / 3600.0);           
            Console.WriteLine("Your speed in meters / second is " + String.Format("{0:0.00000000}", metersPerSecond));
            Console.WriteLine("Your speed in km / h is " + String.Format("{0:0.00000000}", kilometersPerHour));
            Console.WriteLine("Your speed in miles / h is " + String.Format("{0:0.00000000}", milesPerHour));
            Console.ReadKey();
        }
    }
}
