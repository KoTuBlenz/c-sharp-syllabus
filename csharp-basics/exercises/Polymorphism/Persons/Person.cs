using System;

namespace Persons
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int Id { get; set; }
        public Person() { }

        public Person(string first, string last, string homeAdress, int ID)
        {
            FirstName = first;
            LastName = last;
            Adress = homeAdress;
            Id = ID;
        }

        public virtual void Display()
        {
            Console.WriteLine($"First name:{FirstName}, last name: {LastName}.\nHome adress {Adress}, ID: {Id}");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
