using System;

namespace Persons
{
    class Employee :Person
    {
        public string JobTitle { get; set; }

        public Employee(string first, string last, string homeAdress, int ID, string jobTitle) : base(first, last, homeAdress, ID)
        {
            JobTitle = jobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"First name:{FirstName}, last name: {LastName}.\nHome adress {Adress}, ID: {Id}. Job title: {JobTitle}");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
