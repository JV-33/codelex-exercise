using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter animal information:");
                string inputAnimal = Console.ReadLine();
                if (string.IsNullOrEmpty(inputAnimal))
                    break;

                Animal currentAnimal = Animal.CreateAnimal(inputAnimal);

                if (currentAnimal != null)
                {
                    currentAnimal.MakeSound();

                    Console.WriteLine("Enter food information:");
                    string inputFood = Console.ReadLine();
                    Food food = Food.CreateFood(inputFood);

                    if (food != null)
                        currentAnimal.Eat(food);
                }
            }

            Console.WriteLine("Program Ended");
            Console.ReadKey();
        }
    }
}
