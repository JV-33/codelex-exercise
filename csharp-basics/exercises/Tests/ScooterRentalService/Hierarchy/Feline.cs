namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        public Feline(string animalName, double animalWeight, string livingRegion)
            : base(animalName, "Feline", animalWeight, livingRegion)
        {
        }
    }
}