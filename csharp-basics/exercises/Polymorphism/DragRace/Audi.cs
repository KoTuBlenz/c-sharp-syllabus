using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int _currentSpeed = 0;
        public string Name { get; set; }
        public Audi() { }
        public void SpeedUp() 
        {
            _currentSpeed+=14;
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