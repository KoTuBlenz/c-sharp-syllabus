using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int _currentSpeed = 0;
        public string Name { get; set; }

        public void SpeedUp() 
        {
            _currentSpeed+=17;
        }

        public void SlowDown() 
        {
            _currentSpeed-=27;
        }

        public string CurrentSpeed
        {
            get => _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("-- silence ---");
        }
    }
}