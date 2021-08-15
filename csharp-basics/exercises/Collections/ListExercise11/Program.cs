using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var farmAnimals = new List<string>();
            farmAnimals.Add("Dog");
            farmAnimals.Add("Cat");
            farmAnimals.Add("Hamster");
            farmAnimals.Add("Horse");
            farmAnimals.Add("Cow");
            farmAnimals.Add("Parrot");
            farmAnimals.Add("Pig");
            farmAnimals.Add("Mouse");
            farmAnimals.Add("Rat");
            farmAnimals.Add("Rooster");
            farmAnimals.Insert(4, "Chicken");               //Changes 4th element of farmAnimals list to "Chicken"
            farmAnimals[farmAnimals.Count - 1] = "Donkey";  //Changes the last element to "Donkey"
            farmAnimals.Sort();

            if (farmAnimals.Contains("Foobar"))
            {
                Console.WriteLine("List contains \"Foobar\"");
            }
            else
            {
                Console.WriteLine("List does not contain \"Foobar\"");
            }
            
            foreach(string animal in farmAnimals)
            {
                Console.WriteLine(animal);
            }
            Console.ReadKey();
        }
    }
}
