using System;

namespace Persons
{
    class Employee :Person
    {
        public string jobTitle { get; set; }

        public Employee(string first, string last, string homeAdress, int ID, string JobTitle) : base(first, last, homeAdress, ID)
        {
            jobTitle = JobTitle;
        }

        public override void Display()
        {
            Console.WriteLine($"First name:{firstName}, last name: {lastName}.\nHome adress {adress}, ID: {id}. Job title: {jobTitle}");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
