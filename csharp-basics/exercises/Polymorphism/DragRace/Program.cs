using System;
using System.Collections.Generic;
namespace DragRace
{
    interface ICar
    {
        string ShowCurrentSpeed();
        string name { get; set; }
        void SpeedUp();
        void SlowDown();
        void StartEngine();
    }

    interface ICarBoost : ICar
    {
        void UseNitrousOxideEngine();
    }

    class Program
    {
        private static void Main(string[] args)
        {
            List<ICar> carList = new List<ICar>() {};
            carList.Add(new Audi { name = "Audi A4" });
            carList.Add(new Bmw { name = "BMW Z4" });
            carList.Add(new Volvo { name = "Volvo V70" });
            carList.Add(new Opel { name = "Opel GT" });
            carList.Add(new Lexus { name = "Lexus F Sport" });
            carList.Add(new Tesla { name = "Tesla Model S" });
            ICar fastestCar = null;
            int maxSpeed = 0;
            for (int i=0; i<10; i++)
            {
                foreach(ICar car in carList)
                {
                    car.SpeedUp();
                    int speed = int.Parse(car.ShowCurrentSpeed());
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
            Console.WriteLine($"The fastest car is {fastestCar.name} with max speed {fastestCar.ShowCurrentSpeed()}");
            Console.ReadKey();
        }
    }
}