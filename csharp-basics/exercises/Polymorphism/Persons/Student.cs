using System;

namespace Persons
{
    class Student: Person
    {
        public double gpa { get; set; }

        public Student(string first, string last, string homeAdress, int ID, double GPA) : base(first, last, homeAdress, ID)
        {
            gpa = GPA;
        }

        public override void Display()
        {
            Console.WriteLine($"First name:{firstName}, last name: {lastName}.\nHome adress {adress}, ID: {id}. GPA: {gpa}");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
