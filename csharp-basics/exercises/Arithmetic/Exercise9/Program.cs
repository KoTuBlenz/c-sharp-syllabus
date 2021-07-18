using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool usingMetric = false;
            string heightSymbol = "inches";
            string weightSymbol = "pounds";
            Console.WriteLine("Welcome to BMI (body mass index) calculator!\n" +
                "Press M to use metric system (kg & cm) || Press I to use imperial system (lb & inches)");
            char option = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ( option== 'm'|| option == 'M')
            {
                Console.WriteLine("Using metric system");
                usingMetric = true;
                heightSymbol = "centimeters";
                weightSymbol = "kilograms";
            }
            else
            {
                Console.WriteLine("Using imperial system");
            }
            Console.Write($"Enter your height in {heightSymbol}: ");
            double.TryParse(Console.ReadLine(), out double height);
            if (usingMetric)
            {
                height *= 0.393700787;
            }
            Console.Write($"Enter your weight in {weightSymbol}: ");
            double.TryParse(Console.ReadLine(), out double weight);
            if (usingMetric)
            {
                weight *= 2.20462262;
            }
            double bodyMassIndex = weight * 703 / (height * height);
            if (18.5 < bodyMassIndex && bodyMassIndex < 25)
            {
                Console.WriteLine("Your BMI (body mass index) is optimal");
            }
            else if (bodyMassIndex < 18.5)
            {
                Console.WriteLine("You are underweight. Your BMI (body mass index) is lower than optimal ");
            }
            else
            {
                Console.WriteLine("You are overweight. Your BMI (body mass index) is higher than optimal ");
            }

            Console.ReadKey();
            
        }
    }
}
