using System;
using System.Collections.Generic;
namespace DragRace
{


    class Program
    {
        private static void Main(string[] args)
        {
            List<ICar> carList = new List<ICar>() {};
            carList.Add(new Audi { Name = "Audi A4" });
            carList.Add(new Bmw { Name = "BMW Z4" });
            carList.Add(new Volvo { Name = "Volvo V70" });
            carList.Add(new Opel { Name = "Opel GT" });
            carList.Add(new Lexus { Name = "Lexus F Sport" });
            carList.Add(new Tesla { Name = "Tesla Model S" });
            ICar fastestCar = null;
            int maxSpeed = 0;
            for (int i=0; i<10; i++)
            {
                foreach(ICar car in carList)
                {
                    car.SpeedUp();
                    int speed = int.Parse(car.CurrentSpeed);
                    if(maxSpeed < speed)
                    {
                        fastestCar = car;
                        maxSpeed = speed;
                    }
                    
                    if (i==2)
                    {
                        ICarBoost carWithBoost = car as ICarBoost;
                        if (carWithBoost != null)
                        {
                            carWithBoost.UseNitrousOxideEngine();
                        }
                    }
                }
            }
            Console.WriteLine($"The fastest car is {fastestCar.Name} with max speed {fastestCar.CurrentSpeed}");
            Console.ReadKey();
        }
    }
}