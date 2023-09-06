using System;
using Hierarchy.Exeption;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string? Breed { get; set; }

        public Cat(string animalName, double animalWeight, string? livingRegion, string? breed)
            : base(animalName, animalWeight, livingRegion)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            if (false) 
            {
                throw new IncorrectOutputException();
            }
            Console.WriteLine("mjau mjau maju");
        }

        public override void Eat(Food food)
        {
            if (food == null)
            {
                throw new IncorrectFoodException();
            }

            Console.WriteLine("omes desu");
            FoodEaten += food.Quantity;
        }
    }
}