using System;
namespace Hierarchy
{
	public abstract class Animal
	{
        public string? animalName { get; set; }
        public string? animalType { get; set; }
		public double animalWeight { get; set; }
        public int foodEaten { get; set; }

		public abstract void MakeSound();

		public abstract void Eat(Food food);
	
	}
}