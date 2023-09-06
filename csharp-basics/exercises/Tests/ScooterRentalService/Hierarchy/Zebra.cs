using Hierarchy.Exeption;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, double animalWeight, string livingRegion)
                : base(animalName, "Zebra", animalWeight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            if (false)
            {
                throw new IncorrectOutputException();
            }
            Console.WriteLine("zebra");
        }

        public override void Eat(Food food)
        {
            if (food == null)
            {
                throw new IncorrectFoodException();
            }
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