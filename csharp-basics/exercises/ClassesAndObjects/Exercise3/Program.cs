using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to driving sim\n" +
                "Enter current milage");
            Odometer carOdometer = new Odometer(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the fuel amount in the car");
            FuelGauge carFuelGauge = new FuelGauge(int.Parse(Console.ReadLine()));
            while (true)
            {
                Console.Clear();
                carFuelGauge.showFuel();
                carOdometer.showOdo();
                Console.WriteLine("Would you like to fuel up before the ride?(Y/N)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("Enter amount of fuel to add:");
                    int x = int.Parse(Console.ReadLine());
                    for(int i=0; i<x; i++)
                    {
                        if (!carFuelGauge.isTankFull())
                        {
                            carFuelGauge.fillFuelTank();
                        }
                        else
                        {
                            Console.WriteLine($"The tank if full. {i} liters were added");
                            break;
                        }
                    }
                    carFuelGauge.showFuel();
                }
                Console.WriteLine("How many kilometers would you like to travel?");
                int distance = int.Parse(Console.ReadLine());
                for(int i=0; i < distance; i++)
                {
                    if (carFuelGauge.isTankEmpty())
                    {
                        Console.WriteLine($"The car fuel tank is empty. You only traveled {i}km");
                        break;
                    }
                    else
                    {
                        carOdometer.addMilage();
                    }
                }
                carOdometer.showOdo();
                carFuelGauge.showFuel();
                Console.WriteLine("Would you like to drive again?(Y/N)");
                answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
    public class FuelGauge
    {
        private static double _fuel;    //Fuel in the car
        private double _maxFuel = 70;   //Max amount of fuel in the car
        //Fuel gauge constructor
        public FuelGauge(double fuel)
        {
            _fuel = fuel;
            if (isTankFull())
            {
                Console.WriteLine("The fuel tank max size is 70 liters");
                Console.ReadKey();
                _fuel = _maxFuel;
            }
            
        }
        //Displays amount of fuel in car
        public void showFuel()
        {
            Console.WriteLine($"There is {_fuel} liters in car");
        }
        //Fills feul tank by 1 liter
        public void fillFuelTank()
        {
            _fuel++;
           
        }
        //Checks if fuel tank is full and returns bool
        public bool isTankFull()
        {
            return _maxFuel <= _fuel;
        }
        //Checks if fuel tank is empty
        public bool isTankEmpty()
        {
            return _fuel == 0;
        }
        //Removes 1 liter from fuel tank
        public static void burnFuel()
        {
            _fuel--;
        }
    }
    class Odometer
    {
        private int _currentOdo;
        private int _maxMilage = 999999;
        private int _kilometersDriven = 0;
        //Odometer constructor
        //Checks and changes milage depending if milage has reached odometers max value
        public  Odometer (int currentOdo)
        {
            _currentOdo = currentOdo;
            if (hasOdoRechedMax())
            {
                _currentOdo -= _maxMilage;
            }
        }
        //Displays milage of a car
        public void showOdo()
        {
            Console.WriteLine($"Current milage is {String.Format("{0:n0}", _currentOdo)} km");
        }
        //Checks if Odometer has reached its maximum milage
        public bool hasOdoRechedMax()
        {
            return _currentOdo > _maxMilage;
        }
        //Adds milage to odometer and burns 1 liter of fuel for every 10km
        public void addMilage()
        {
            if (hasOdoRechedMax()) _currentOdo = 0;
            _kilometersDriven++;
            if (_kilometersDriven % 10 == 0)
            {
                FuelGauge.burnFuel();
            }
            _currentOdo++;
        }
    }
}
