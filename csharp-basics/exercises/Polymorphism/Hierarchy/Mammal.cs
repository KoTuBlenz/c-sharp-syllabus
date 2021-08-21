using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal: Animal
    {
        public virtual string livingRegion { get; set; }
 
        public override string ToString()
        { 
            return $"{animalType} [{name}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
