using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Mouse: Mammal
    {
        string foodType = "vegetable";
        public Mouse(string Name, double AnimalWeight, string LivingRegion)
        {
            animalType = "Mouse";
            name = Name;
            animalWeight = AnimalWeight;
            livingRegion = LivingRegion;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Squeak");
        }

        public override bool IsFoodCorrect(string food)
        {
            return foodType.Contains(food);
        }
    }
}

