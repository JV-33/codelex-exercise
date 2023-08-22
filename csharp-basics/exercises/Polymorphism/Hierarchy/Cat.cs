using System;
namespace Hierarchy
{
    public class Cat : Feline
    {
        public string? breed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("mjau mjau maju ");
        }

        public override void Eat(Food food)
        {
            Console.WriteLine("omes desu");
        }
    }
}
