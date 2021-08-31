using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double finalPosition = GravityCalculator.CalculateFinalPosition(gravity, initialVelocity, fallingTime, initialPosition);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }
    public class GravityCalculator
    {
        public static double CalculateFinalPosition(double gravity, double initialVelocity, double fallingTime, double initialPosition)
        {
            return (0.5 * (fallingTime * fallingTime) * gravity) + initialPosition + (initialVelocity*fallingTime);
        }
    }
}
