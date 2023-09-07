namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string? LivingRegion { get; set; } 

        protected Mammal(string animalName, double animalWeight, string? livingRegion)
            : base(animalName, animalWeight) 
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{AnimalType}[{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
