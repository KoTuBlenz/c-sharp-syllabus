using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Opel : ICar
    {
        private int currentSpeed = 0;
        public string name { get; set; }

        public void SpeedUp()
        {
            currentSpeed += 13;
        }

        public void SlowDown()
        {
            currentSpeed -= 20;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Brum.........");
        }
    }
}
