using System;
namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter animal information :");
                string inputAnimal = Console.ReadLine();
                if (string.IsNullOrEmpty(inputAnimal))
                    break;

                Animal currentAnimal = CreateAnimal(inputAnimal);

                if (currentAnimal != null)
                {
                    currentAnimal.MakeSound();

                    Console.WriteLine("Enter food information:");
                    string inputFood = Console.ReadLine();
                    Food food = CreateFood(inputFood);

                    if (food != null)
                        currentAnimal.Eat(food);
                }
            }

            Console.WriteLine("Program Ended");
        }

        static Animal CreateAnimal(string input)
        {
            string[] parts = input.Split(' ');

            switch (parts[0].ToLower())
            {
                case "cat":
                    return new Cat
                    {
                        animalType = parts[0],
                        animalName = parts[1],
                        animalWeight = double.Parse(parts[2]),
                        livingRegion = parts[3],
                        breed = parts[4]
                    };
                case "tiger":
                    return new Tiger
                    {
                        animalType = parts[0],
                        animalName = parts[1],
                        animalWeight = double.Parse(parts[2]),
                        livingRegion = parts[3],
                    };
                case "mouse":
                    return new Mouse
                    {
                        animalType = parts[0],
                        animalName = parts[1],
                        animalWeight = double.Parse(parts[2]),
                        livingRegion = parts[3],
                    };
                case "zebra":
                    return new Zebra
                    {
                        animalType = parts[0],
                        animalName = parts[1],
                        animalWeight = double.Parse(parts[2]),
                        livingRegion = parts[3],
                    };
                default:
                    Console.WriteLine("Unknown animal type!");
                    return null;
            }
        }

        static Food CreateFood(string input)
        {
            string[] parts = input.Split(' ');

            switch (parts[0].ToLower())
            {
                case "meat":
                    return new Meat { Quantity = int.Parse(parts[1]) };
                case "vegetable":
                    return new Vegetable { Quantity = int.Parse(parts[1]) };
                default:
                    Console.WriteLine("Unknown food type!");
                    return null;
            }
            Console.ReadKey();
        }
    }
}