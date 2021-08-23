using System;
using System.Collections.Generic;
namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalList = new List<Animal>();
            int i = 0;
            while (true)
            {
                var input=Console.ReadLine().Split(' ');
                if(input[0].ToLower() == "end")
                {
                    break;
                }
                var animalType = input[0];
                var name = input[1];
                var animalWeight = double.Parse(input[2]);
                var livingRegion = input[3];
                switch (animalType.ToLower())
                {
                    case "cat":
                        var breed = input[4];
                        animalList.Add(new Cat(name, animalWeight, livingRegion, breed));
                        break;
                    case "tiger":
                        animalList.Add(new Tiger(name, animalWeight, livingRegion));
                        break;
                    case "zebra":
                        animalList.Add(new Zebra(name, animalWeight, livingRegion));
                        break;
                    case "mouse":
                        animalList.Add(new Mouse(name, animalWeight, livingRegion));
                        break;
                    default:
                        Console.WriteLine("Incorrect type");
                        return;
                }
                animalList[i].MakeNoise();
                input = Console.ReadLine().Split(' ');
                Food food;
                switch (input[0].ToLower())
                {
                    case "vegetable":
                        food = new Vegetable(int.Parse(input[1]));
                        break;
                    case "meat":
                        food = new Meat(int.Parse(input[1]));
                        break;
                    default:
                        Console.WriteLine("Incorrect input");
                        return;
                }
                animalList[i].EatFood(animalList[i].IsFoodCorrect(food.Type), food.Amount);
                Console.WriteLine(animalList[i].ToString());
                i++;
            }
            var animalStringList = new List<String>();
            animalList.ForEach(animal => animalStringList.Add(animal.ToString()));
            Console.WriteLine(String.Join(", ", animalStringList));
        }
    } 
}
