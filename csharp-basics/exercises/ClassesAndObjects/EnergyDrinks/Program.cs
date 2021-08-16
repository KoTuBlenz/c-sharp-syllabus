using System;


namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately " + CalculateEnergyDrinkers(NumberedSurveyed) + " bought at least one energy drink");
             Console.WriteLine(CalculatePreferCitrus(CalculateEnergyDrinkers(NumberedSurveyed)) + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        static double CalculateEnergyDrinkers(double numberSurveyed)
        {
            return Math.Round(numberSurveyed * PurchasedEnergyDrinks);
        }

        static double CalculatePreferCitrus(double numberSurveyed)
        {
            return Math.Round(numberSurveyed * PreferCitrusDrinks);
        }
    }
}
