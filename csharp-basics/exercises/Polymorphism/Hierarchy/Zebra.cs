using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Zebra: Mammal
    {
        private string _foodType = "vegetable";
        public Zebra(string name, double animalWeight, string livingRegion)
        {
            AnimalType = "Zebra";
            Name = name;
            AnimalWeight = animalWeight;
            LivingRegion = livingRegion;
        }


        public override bool IsFoodCorrect(string food)
        {
            return _foodType.Contains(food);
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Whinny");
        }
    }
}
