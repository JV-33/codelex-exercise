namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public string livingRegion { get; set; }

        public override string ToString()
        {
            return $"{animalType}[{animalName}, {animalWeight}, {livingRegion}, {foodEaten}]";
        }
    }
}
