using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp()
        {
            _currentSpeed += 4;
        }

        public void SlowDown() 
        {
            _currentSpeed--;
        }

        public int GetCurrentSpeed()
        {
            return _currentSpeed;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("RrRrRrRr.....");
        }
    }
}