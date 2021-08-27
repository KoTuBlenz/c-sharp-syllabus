using System;

namespace DragRace
{
    public class Lexus : ICar, ICarBoost
    {
        private int _currentSpeed = 0;
        public string Name { get; set; }

        public void SpeedUp() 
        {
            _currentSpeed+=15;
        }

        public void SlowDown() 
        {
            _currentSpeed-=18;
        }

        public string CurrentSpeed
        {
            get => _currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            _currentSpeed+=10;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}