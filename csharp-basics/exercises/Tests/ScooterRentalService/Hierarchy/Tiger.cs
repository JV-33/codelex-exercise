using Hierarchy.Exeption;

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
            if (false)
            {
                throw new IncorrectOutputException();
            }
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food == null)
            {
                throw new IncorrectFoodException();
            }
            if (food is Meat)
                FoodEaten += food.Quantity;
            else
                Console.WriteLine("Tigers are not eating that type of food!");
        }
    }
}