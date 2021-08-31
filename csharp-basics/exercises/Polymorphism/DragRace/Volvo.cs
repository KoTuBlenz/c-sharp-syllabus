using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Volvo : ICar, ICarBoost
    {
        private int _currentSpeed = 0;
        public string Name { get; set; }

        public void SpeedUp()
        {
            _currentSpeed += 12;
        }

        public void SlowDown()
        {
            _currentSpeed -= 22;
        }

        public string CurrentSpeed
        {
            get => _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            _currentSpeed += 10;
        }
        public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}
