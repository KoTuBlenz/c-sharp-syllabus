using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            var carList = new List<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            foreach(string car in carList)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("\n");

            var carHashSet = new HashSet<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            foreach (string car in carHashSet)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("\n");

            var carDictionary = new Dictionary<string,string>() {};
            carDictionary.Add("Audi", "Germany");
            carDictionary.Add("BMW", "Germany");
            carDictionary.Add("Honda", "Japan");
            carDictionary.Add("Mercedes", "Germany");
            carDictionary.Add("VolksWagen", "Germany");
            carDictionary.Add("Tesla", "USA");
            foreach(KeyValuePair<string,string> car in carDictionary)
            {
                Console.WriteLine($"Car brand \"{car.Key}\" is manufactured in {car.Value}");
            }
            Console.ReadKey();
        }
    }
}
