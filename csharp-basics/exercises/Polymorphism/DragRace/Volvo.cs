using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    class Volvo : ICar, ICarBoost
    {
        private int currentSpeed = 0;
        public string name { get; set; }

        public void SpeedUp()
        {
            currentSpeed += 12;
        }

        public void SlowDown()
        {
            currentSpeed -= 22;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 10;
        }
        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
