using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
   public abstract class Animal
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string MakeNoise();
        public abstract bool IsFoodCorrect(string food);
        public new abstract string ToString();

        public void EatFood(bool isFoodCorrect, int amountOfFood)
        {
            if (isFoodCorrect)
            {
                FoodEaten += amountOfFood;
            }
            else
            {
                Console.WriteLine($"{AnimalType}s are not eating that type of food!");
            }
        }
    }
}
