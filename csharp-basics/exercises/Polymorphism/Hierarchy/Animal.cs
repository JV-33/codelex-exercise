using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }
        public string AnimalType { get; set; }
        public double AnimalWeight { get; set; }
        public int FoodEaten { get; set; }

        protected Animal(string animalName, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalWeight = animalWeight;
        }

        public abstract void MakeSound();
        public abstract void Eat(Food food);

        public static Animal CreateAnimal(string input)
        {
            string[] parts = input.Split(' ');

            switch (parts[0].ToLower())
            {
                case "cat":
                    return new Cat(parts[1], double.Parse(parts[2]), parts[3], parts[4]); 
                case "tiger":
                    return new Tiger(parts[1], double.Parse(parts[2]), parts[3]);
                case "mouse":
                    return new Mouse(parts[1], double.Parse(parts[2]), parts[3]);
                case "zebra":
                    return new Zebra(parts[1], double.Parse(parts[2]), parts[3]);
                default:
                    Console.WriteLine("Unknown animal type!");
                    return null;
            }
        }
    }
}
