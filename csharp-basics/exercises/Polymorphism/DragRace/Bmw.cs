using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int _currentSpeed = 0;
        public string Name { get; set; }
        public void SpeedUp() 
        {
            _currentSpeed+=15;
        }

        public void SlowDown() 
        {
            _currentSpeed-=20;
        }

        public string CurrentSpeed
        {
            get => _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}