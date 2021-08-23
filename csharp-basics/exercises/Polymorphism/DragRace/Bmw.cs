using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed = 0;
        public string name { get; set; }
        public void SpeedUp() 
        {
            currentSpeed+=15;
        }

        public void SlowDown() 
        {
            currentSpeed-=20;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}