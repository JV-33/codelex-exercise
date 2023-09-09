using System;

namespace Hierarchy
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        public static Food CreateFood(string input)
        {
            string[] parts = input.Split(' ');

            switch (parts[0].ToLower())
            {
                case "meat":
                    return new Meat { Quantity = int.Parse(parts[1]) };
                case "vegetable":
                    return new Vegetable { Quantity = int.Parse(parts[1]) };
                default:
                    Console.WriteLine("Unknown food type!");
                    return null;
            }
        }
    }
}
