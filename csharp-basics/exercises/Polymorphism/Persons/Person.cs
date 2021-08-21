using System;

namespace Persons
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string adress { get; set; }
        public int id { get; set; }
        public Person() { }

        public Person(string first, string last, string homeAdress, int ID)
        {
            firstName = first;
            lastName = last;
            adress = homeAdress;
            id = ID;
        }

        public virtual void Display()
        {
            Console.WriteLine($"First name:{firstName}, last name: {lastName}.\nHome adress {adress}, ID: {id}");
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}
