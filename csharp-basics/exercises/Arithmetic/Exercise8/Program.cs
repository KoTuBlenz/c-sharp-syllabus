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
            var salary1 = new SalaryCalculator(7.50, 35);
            var salary2 = new SalaryCalculator(8.20, 47);
            var salary3 = new SalaryCalculator(10.00, 73);
            Console.WriteLine(salary1.ToString());
            Console.WriteLine(salary2.ToString());
            Console.WriteLine(salary3.ToString());
            Console.WriteLine(Math.PI);
            Console.ReadKey();

        }
        //static void salaryCalculator(double basePay, int hoursWorked)
        //{
        //    if (basePay < 8.00)
        //    {
        //        Console.WriteLine("Error: Base pay is too low");
        //        return;
        //    }

        //    if (hoursWorked > 60)
        //    {
        //        Console.WriteLine("Error: Too many worked hours");
        //        return;
        //    }
        //    double salary;
        //    if (hoursWorked < 40)
        //    {
        //        salary = basePay * hoursWorked;
        //    }
        //    else
        //    {
        //        salary = basePay * 40;
        //        salary += (basePay * 1.5) * (hoursWorked - 40);
        //    }
        //    Console.WriteLine("Employee recieves: " + String.Format("{0:0.00}", salary)+ $"$ for {hoursWorked} hours worked at base pay {basePay}");
        //}
    }
    public class SalaryCalculator
    {
        private double _basePay;
        private int _hoursWorked;
        public SalaryCalculator (double basePay, int hoursWorked)
        {
            _basePay = basePay;
            _hoursWorked = hoursWorked;
        }
        public bool IsBasePayTooLow()
        {
            return _basePay < 8.00;
        }
        public bool AreWorkedHoursTooMany()
        {
            return _hoursWorked > 60;
        }
        public string CalculateSalary()
        {
            double salary;
            
            if (_hoursWorked < 40)
            {
                salary = _basePay * _hoursWorked;
                return String.Format("{0:0.00}", salary);
            }
            else
            {
                salary = _basePay * 40;
                salary += (_basePay * 1.5) * (_hoursWorked - 40);
                return String.Format("{0:0.00}", salary);
            }
        }
        public override string ToString()
        {
            if (IsBasePayTooLow())
            {
                return "Error: Base pay is too low";
            }
            else if (AreWorkedHoursTooMany())
            {
                return "Error: Worked hours are too many";
            }
            else
            {
                return $"Employee recieves: ${CalculateSalary()} " +
                    $"for {_hoursWorked} hours worked at base pay ${_basePay}";
            }
        }
    }
}
