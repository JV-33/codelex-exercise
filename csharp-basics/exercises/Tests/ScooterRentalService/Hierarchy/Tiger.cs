using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, double animalWeight, string? livingRegion)
            : base(animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
                FoodEaten += food.Quantity;
            else
                Console.WriteLine("Tigers are not eating that type of food!");
        }
    }
}