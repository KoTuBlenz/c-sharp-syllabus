using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Opel : ICar
    {
        private int _currentSpeed = 0;
        public string Name { get; set; }

        public void SpeedUp()
        {
            _currentSpeed += 13;
        }

        public void SlowDown()
        {
            _currentSpeed -= 20;
        }

        public string CurrentSpeed
        {
            get => _currentSpeed.ToString();
        }

        public void StartEngine()
        {
            Console.WriteLine("Brum.........");
        }
    }
}
