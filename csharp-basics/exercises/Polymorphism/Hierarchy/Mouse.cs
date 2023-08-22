using System;
namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("pee pee pee");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
                Console.WriteLine("Mouse eating vegetable");
            else
                Console.WriteLine("Mouse are not eating that type of food!");
        }
    }
}

