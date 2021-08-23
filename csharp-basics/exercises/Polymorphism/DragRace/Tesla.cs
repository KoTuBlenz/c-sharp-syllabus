using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;
        public string name { get; set; }

        public void SpeedUp() 
        {
            currentSpeed+=17;
        }

        public void SlowDown() 
        {
            currentSpeed-=27;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}