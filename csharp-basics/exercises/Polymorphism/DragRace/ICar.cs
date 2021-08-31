using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface ICar
    {
        string CurrentSpeed { get; }
        string Name { get; set; }
        void SpeedUp();
        void SlowDown();
        void StartEngine();
    }
}
