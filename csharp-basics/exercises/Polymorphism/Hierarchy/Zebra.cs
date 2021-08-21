using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra: Mammal
    {
        string foodType = "vegetable";

        public Zebra(string Name, double AnimalWeight, string LivingRegion)
        {
            animalType = "Zebra";
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
            Console.WriteLine("Whinny");
        }
    }
}
