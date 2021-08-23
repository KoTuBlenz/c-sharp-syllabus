using System;

namespace DragRace
{
    public class Audi :ICar
    {
        private int currentSpeed = 0;
        public string name { get; set; }
        public Audi() { }
        public void SpeedUp() 
        {
            currentSpeed+=14;
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