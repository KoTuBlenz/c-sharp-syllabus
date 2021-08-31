using System;
using System.Collections.Generic;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        private static void Main(string[] args)
        {
            string path = "../../flights.txt";
            var flights = new FlightPlanner(File.ReadAllText(path));

            if (int.TryParse(Console.ReadLine(), out int x))
            {
                if (x == 1)
                {
                    Console.Clear();
                    Console.WriteLine(string.Join("\n", flights.StartingCities()));
                    string startingCity;
                    //Sets startingCity and displays list of targetCities
                    while (true) 
                    {
                        Console.WriteLine("Enter a city from which you would like to start");
                        startingCity = Console.ReadLine();
                        var targetCities = flights.TargetCities(startingCity);
                        if (targetCities == null)
                        {
                            Console.WriteLine("City not found");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Starting city: {startingCity}\n" + $"\nPossible target cities:\n" + $"{string.Join("\n", targetCities)}");
                            break;
                        }
                    }
                    //Sets targetCity and, if successful, displays flight from startingCity to targetCity
                    while (true)   
                    {
                        Console.WriteLine("Enter city to which you would like to travel to");
                        string targetCity = Console.ReadLine();
                        var flight = flights.FlightRoute(startingCity, targetCity);
                        if (flight != null)
                        {
                            Console.Clear();
                            Console.WriteLine(flight);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("City not found");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
