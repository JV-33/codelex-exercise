using System;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
                foodEaten += food.Quantity;
            else
                Console.WriteLine("Tigers are not eating that type of food!");
        }
    }
}
