using System;

namespace DragRace
{
    public class Lexus : ICar, ICarBoost
    {
        private int currentSpeed = 0;
        public string name { get; set; }

        public void SpeedUp() 
        {
            currentSpeed+=15;
        }

        public void SlowDown() 
        {
            currentSpeed-=18;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed+=10;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}