using System;

namespace Persons
{
    class Student: Person
    {
        private double _gpa;
        public Student(string first, string last, string homeAdress, int ID, double gpa) : base(first, last, homeAdress, ID)
        {
            _gpa = gpa;
        }

        public override void Display()
        {
            Console.WriteLine($"First name:{FirstName}, last name: {LastName}.\nHome adress {Adress}, ID: {Id}. GPA: {_gpa}");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
