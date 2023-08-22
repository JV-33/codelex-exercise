using System;
namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("zebra");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
                Console.WriteLine("Zebra eating grass");
            else
                Console.WriteLine("Zebra are not eating that type of food!");
        }
    }
}

