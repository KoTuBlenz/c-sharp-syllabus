using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        public SortedDictionary<string, string> PhoneEntryList = new SortedDictionary<string, string>();
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
                var newEntry = new PhoneEntry { name = name, number = number };
                PhoneEntryList.Add(name, number);                               
            }
        }
        public override string ToString()
        {
            var phoneEntries= new List<string>();
            foreach (KeyValuePair<string, string> kvp in PhoneEntryList)
            {
                phoneEntries.Add($"{kvp.Key}: {kvp.Value}");
            }
            return string.Join("\n", phoneEntries);
        }
    }
}