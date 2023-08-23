using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string animalName { get; set; }
        public string animalType { get; set; }
        public double animalWeight { get; set; }
        public int foodEaten { get; set; }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

        public static Animal CreateAnimal(string input)
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
                        livingRegion = parts[3]
                    };
                case "mouse":
                    return new Mouse
                    {
                        animalType = parts[0],
                        animalName = parts[1],
                        animalWeight = double.Parse(parts[2]),
                        livingRegion = parts[3]
                    };
                case "zebra":
                    return new Zebra
                    {
                        animalType = parts[0],
                        animalName = parts[1],
                        animalWeight = double.Parse(parts[2]),
                        livingRegion = parts[3]
                    };
                default:
                    Console.WriteLine("Unknown animal type!");
                    return null;
            }
        }
    }
}
