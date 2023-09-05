using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> sound = new List<ISound>
            {
                new Radio(),
                new Parrot(),
                new Firework(),
            };

            foreach (var item in sound)
            {
                item.PlaySound();
            }

            Console.ReadKey();
        }
    }
}