using System;

namespace DragRace
{
    public class Lexus : ICar, INitros
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 2;
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

        public void UseNitrousOxideEngine() 
        {
            _currentSpeed += 3;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Zzzzzzzzz.....");
        }
    }
}