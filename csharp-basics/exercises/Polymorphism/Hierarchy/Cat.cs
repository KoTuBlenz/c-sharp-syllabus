using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat: Feline
    {
        string foodType = "vegetable, meat";
        private string _breed;

        public Cat(string Name, double AnimalWeight, string LivingRegion, string breed)
        {
            animalType = "Cat";
            name = Name;
            animalWeight = AnimalWeight;
            livingRegion = LivingRegion;
            _breed = breed;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Meow");
        }

        public override bool IsFoodCorrect(string food)
        {
            return foodType.Contains(food);
        }

        public override string ToString()
        {
            return $"{animalType} [{name}, {_breed}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
