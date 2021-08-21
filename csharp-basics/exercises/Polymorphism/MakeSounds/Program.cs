using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var soundList = new List<ISound>() { new Firework(), new Parrot(), new Radio(), new Firework(), new Radio() };
            soundList.ForEach(sound => sound.PlaySound());
            Console.ReadKey();
        }
    }
}