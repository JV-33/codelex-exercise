using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ICar> cars = new List<ICar>
            {
                new Audi(),
                new Bmw(),
                new Lexus(),
                new Tesla(),
                new Volga(),
                new Volvo(),
            };

            foreach (var car in cars)
            {
                car.StartEngine();
            }

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in cars)
                {
                    car.SpeedUp();

                    if (i == 2 && car is INitros boostedCar)
                    {
                        boostedCar.UseNitrousOxideEngine();
                    }
                }
            }

            ICar fastestCar = cars.OrderBy(car => car.GetCurrentSpeed()).LastOrDefault();
            Console.WriteLine($"The fastest car is {fastestCar.GetType().Name} with a speed of {fastestCar.ShowCurrentSpeed()} km/h.");

            Console.ReadKey();
        }    
    }
}