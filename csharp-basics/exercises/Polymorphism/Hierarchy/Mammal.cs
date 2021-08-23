using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal: Animal
    {
        public virtual string LivingRegion { get; set; }
 
        public override string ToString()
        { 
            return $"{AnimalType} [{Name}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
