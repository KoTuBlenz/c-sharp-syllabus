using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            int seatsInACar = 4;
            int drivers = 28;
            int passengers = 90;
            int carsNotDriven = cars - drivers;
            int carsDriven = drivers;
            int carpoolCapacity = 28 * seatsInACar;
            double averagePassengersPerCar = passengers / (double)carsDriven;
            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + String.Format("{0:0.00}", averagePassengersPerCar) + " in each car.");
            Console.ReadKey();
        }
    }
}