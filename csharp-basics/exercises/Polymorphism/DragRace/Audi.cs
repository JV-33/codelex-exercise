using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 3;
        }

        public int GetCurrentSpeed()
        {
            return _currentSpeed;
        }

        public void SlowDown() 
        {
            _currentSpeed--;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Laba skaņa....");
        }
    }
}