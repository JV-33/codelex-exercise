﻿using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        public string? Breed { get; set; }

        public Cat(string animalName, double animalWeight, string? livingRegion, string? breed)
            : base(animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("mjau mjau maju ");
        }

        public override void Eat(Food food)
        {
            Console.WriteLine("omes desu");
            this.FoodEaten += food.Quantity; 
        }
    }
}
