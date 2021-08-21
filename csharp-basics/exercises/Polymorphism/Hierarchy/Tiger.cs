using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Tiger: Feline
    {
        string foodType = "meat";
        public Tiger(string Name, double AnimalWeight, string LivingRegion)
        {
            animalType = "Tiger";
            name = Name;
            animalWeight = AnimalWeight;
            livingRegion = LivingRegion;
        }

        public override bool IsFoodCorrect(string food)
        {
            return foodType.Contains(food);
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Roar");
        }
    }
}
