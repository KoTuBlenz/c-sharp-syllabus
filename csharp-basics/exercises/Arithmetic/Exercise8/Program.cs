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
            salaryCalculator(7.50, 35);
            salaryCalculator(8.20, 47);
            salaryCalculator(10.00, 73);
            Console.ReadKey();

        }
        static void salaryCalculator(double basePay, int hoursWorked)
        {
            if (basePay < 8.00)
            {
                Console.WriteLine("Error: Base pay is too low");
                return;
            }

            if (hoursWorked > 60)
            {
                Console.WriteLine("Error: Too many worked hours");
                return;
            }
            double salary;
            if (hoursWorked < 40)
            {
                salary = basePay * hoursWorked;
            }
            else
            {
                salary = basePay * 40;
                salary += (basePay * 1.5) * (hoursWorked - 40);
            }
            Console.WriteLine("Employee recieves: " + String.Format("{0:0.00}", salary)+ $"$ for {hoursWorked} hours worked at base pay {basePay}");
        }
    }
}
