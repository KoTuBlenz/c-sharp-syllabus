using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Andre", "Peterson", "Florida, Park Avenue 5b", 14678, 5.72);
            var employee = new Employee("Pablo", "Escobar", "Washington D.C., Pennsylvania Avenue 1600, ", 7734, "The Mathematics Professor");
            student1.Display();
            employee.Display();
            Console.ReadKey();
        }
    }
}