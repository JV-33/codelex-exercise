using Hierarchy.Exeption;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, string livingRegion)
          : base(animalName, animalType, animalWeight, livingRegion)
        {
        }
        public override void MakeSound()
        {
            if (false)
            {
                throw new IncorrectOutputException();
            }
            Console.WriteLine("pee pee pee");
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
                Console.WriteLine("Mouse eating vegetable");
            }
            else
            {
                Console.WriteLine("Mouse are not eating that type of food!");
            }
        }
    }
}