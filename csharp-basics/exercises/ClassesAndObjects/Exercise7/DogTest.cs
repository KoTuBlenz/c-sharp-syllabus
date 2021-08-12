using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {

            Dog dog1 = new Dog("Max", "male", "Lady ", "Rocky");
            Dog dog2 = new Dog("Rocky", "male", "Molly", "Sam");
            Dog dog3 = new Dog("Sparky", "male", null, null);
            Dog dog4 = new Dog("Buster", "male", "Lady", "Sparky");
            Dog dog5 = new Dog("Sam", "male", null, null);
            Dog dog6 = new Dog("Lady", "female", null, null);
            Dog dog7 = new Dog("Molly", "female", null, null);
            Dog dog8 = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine($"Coco's father is {dog8.FathersName()}");
            Console.WriteLine($"Sparky's father is {dog3.FathersName()}");
            Console.WriteLine($"Coco has the same mother as Rocky: {dog8.HasSameMotherAs(dog2)}");
            Console.ReadKey();
        }
}
}
