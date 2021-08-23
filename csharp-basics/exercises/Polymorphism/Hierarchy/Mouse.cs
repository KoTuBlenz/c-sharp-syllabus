using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Mouse: Mammal
    {
        private string _foodType = "vegetable";
        public Mouse(string name, double animalWeight, string livingRegion)
        {
            AnimalType = "Mouse";
            Name = name;
            AnimalWeight = animalWeight;
            LivingRegion = livingRegion;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Squeak");
        }

        public override bool IsFoodCorrect(string food)
        {
            return _foodType.Contains(food);
        }
    }
}

