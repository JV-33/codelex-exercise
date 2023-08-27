namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        protected Feline(string animalName, double animalWeight, string? livingRegion)
            : base(animalName, animalWeight, livingRegion)
        {
        }
    }
}
