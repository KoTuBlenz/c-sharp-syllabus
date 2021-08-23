using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Tiger: Feline
    {
        private string _foodType = "meat";
        public Tiger(string name, double animalWeight, string livingRegion)
        {
            AnimalType = "Tiger";
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
            Console.WriteLine("Roar");
        }
    }
}
