using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat: Feline
    {
        private string _foodType = "vegetable, meat";
        private string _breed;

        public Cat(string name, double animalWeight, string livingRegion, string breed)
        {
            AnimalType = "Cat";
            Name = name;
            AnimalWeight = animalWeight;
            LivingRegion = livingRegion;
            _breed = breed;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }

        public override bool IsFoodCorrect(string food)
        {
            return _foodType.Contains(food);
        }

        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {_breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
