using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> PhoneEntryList = new SortedDictionary<string, string>();
        public PhoneDirectory() { }

        public string GetNumber(string name)
        {
            if (!PhoneEntryList.ContainsKey(name))
            {
                return null;
            }
            else
            {
                return PhoneEntryList[name];
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                throw new Exception("name and number cannot be null");
            }
            if (PhoneEntryList.ContainsKey(name))
            {
                PhoneEntryList[name] = number;
            }
            else
            {
                var newEntry = new PhoneEntry { name = name, number = number }; //Is the PhoneEntry object necessary,..
                PhoneEntryList.Add(name, number);                               //..if the the name is saved as dictionaries key and phone number is the value?
            }
        }
        //Prints the list of numbers sorted alphabetically by the name
        //Used to check if the values are stored correctly in the dictionary
        public void PrintPhoneDirectory()
        {
            foreach (KeyValuePair<string, string> kvp in PhoneEntryList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}