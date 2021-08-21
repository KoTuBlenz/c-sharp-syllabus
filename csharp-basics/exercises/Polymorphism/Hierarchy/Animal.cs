using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
   abstract class Animal
    {
        public string name { get; set; }
        public string animalType { get; set; }
        public double animalWeight { get; set; }
        public int foodEaten { get; set; }

        public abstract void MakeNoise();
        public abstract bool IsFoodCorrect(string food);
        public new abstract string ToString();

        public void EatFood(bool isFoodCorrect, int amountOfFood)
        {
            if (isFoodCorrect)
            {
                foodEaten += amountOfFood;
            }
            else
            {
                Console.WriteLine($"{animalType}s are not eating that type of food!");
            }
        }
    }
}
