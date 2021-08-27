using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code to Test phone directory class
            var numberList = new PhoneBook.PhoneDirectory();
            numberList.PutNumber("Jack", "23045231");
            numberList.PutNumber("Jonh", "21433211");
            numberList.PutNumber("Alfred", "23412441");
            numberList.PutNumber("Zack", "25766794");
            Console.WriteLine($"Jack phone number is {numberList.GetNumber("Jack")}");
            Console.WriteLine($"Jonh phone number is {numberList.GetNumber("Jonh")}");
            Console.WriteLine(numberList.ToString());
            Console.ReadKey();
        }
    }
}
