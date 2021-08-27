using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Mouse: Mammal
    {
        private string _foodType = "vegetable";
        public Mouse(string name, double animalWeight, string livingRegion)
        {
            AnimalType = "Mouse";
            Name = name;
            AnimalWeight = animalWeight;
            LivingRegion = livingRegion;
        }

        public override string MakeNoise()
        {
            return "Squeak";
        }

        public override bool IsFoodCorrect(string food)
        {
            return _foodType.Contains(food.ToLower());
        }
    }
}

