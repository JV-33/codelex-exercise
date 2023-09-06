using System;
using Hierarchy.Exeption;

namespace Hierarchy
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; set; }

        public static Food CreateFood(string input)
        {
            string[] parts = input.Split(' ');

            switch (parts[0].ToLower())
            {
                case "meat":
                    return new Meat(int.Parse(parts[1]));
                case "vegetable":
                    return new Vegetable(int.Parse(parts[1]));

                default:
                    throw new UnknownFoodException();
            }
        }
    }
}