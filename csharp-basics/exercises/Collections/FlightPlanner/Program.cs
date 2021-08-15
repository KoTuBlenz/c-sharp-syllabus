using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static Dictionary<string, List<string>> _flightList = new Dictionary<string, List<string>>() { };
        private static void Main(string[] args)
        {
            FillFlightList(Path);
            Console.WriteLine("Choose one of the options\n" +
                "1.Choose a flight\n" +
                "0.Exit Program");
            if (checkUserInput() == 1)
            {
                Console.Clear();
                PrintFlightList();
                string city;
                while (true)
                {
                    Console.WriteLine("Enter a city from which you would like to start");
                    city = Console.ReadLine();
                    if (!_flightList.ContainsKey(city))
                    {
                        Console.WriteLine("City not found");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Starting city: {city}\n" +
                            $"\nPossible target cities:");
                        PrintTargetCities(city);
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter city to which you would like to travel to");
                    string targetCity = Console.ReadLine();
                    if (_flightList[city].Contains(targetCity))
                    {
                        Console.Clear();
                        Console.WriteLine($"Your chosen flight is: |{city}| => |{targetCity}|");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("City not found");
                    }
                }
            }
            Console.ReadKey();
        }

        public static int checkUserInput()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int x))
                {
                    return x;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }

        public static void FillFlightList(string path)
        {
            var readText = File.ReadAllLines(path);
            foreach (var s in readText)
            {
                string[] cities = s.Replace(" -> ", "-").Split('-');
                if (!_flightList.ContainsKey(cities[0]))
                {
                    _flightList.Add(cities[0], new List<string>() { cities[1] });
                }
                else
                {
                    _flightList[cities[0]].Add(cities[1]);
                }
            }
        }

        public static void PrintTargetCities(string targetCity)
        {
            foreach (string city in _flightList[targetCity])
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }

        public static void PrintFlightList()
        {
            foreach (KeyValuePair<string, List<string>> kvp in _flightList)
            {
                Console.WriteLine(kvp.Key);
            }
            Console.WriteLine();
        }
    }
}
