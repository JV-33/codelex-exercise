using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, double animalWeight, string? livingRegion)
            : base(animalName, animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("zebra");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity; 
                Console.WriteLine("Zebra eating grass");
            }
            else
            {
                Console.WriteLine("Zebra are not eating that type of food!");
            }
        }
    }
}
