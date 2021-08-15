using System;
using System.Collections.Generic;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static IList<Car> _carList = new List<Car>() { };
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to fuel consumption calculator\n");
                displayCarList();
                Console.WriteLine("Press 1 To calculate consumption\n" +
                    "Press 0 to exit");
                if (int.Parse(Console.ReadLine()) != 1)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine("\nEnter first odometer reading");
                Car car1 = new Car(double.Parse(Console.ReadLine()));
                Console.WriteLine("Enter second odometer reading");
                double secondReading = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter fuel used");
                double fuel = double.Parse(Console.ReadLine());
                car1.FillUp(secondReading, fuel);
                _carList.Add(car1);
            }
        }

        //Displays list of cars and their fuel consumption
        public static void displayCarList()
        {
            if (_carList.Count > 0)
            {
                int i = 1;
                foreach (Car car in _carList)
                {
                    if (car.GasHog()) Console.WriteLine($"Car #{i} fuel consumption is {car.ConsumptionPer100Km()} liters per 100km, and the car is a Gas Hog");
                    else if (car.EconomyCar()) Console.WriteLine($"Car #{i} fuel consumption is {car.ConsumptionPer100Km()} liters per 100km, and the car is economic");
                    else Console.WriteLine($"Car #{i} fuel consumption is {car.ConsumptionPer100Km()} liters per 100km, and the car has average fuel consuption");
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
