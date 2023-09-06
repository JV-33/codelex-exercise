namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected string LivingRegion { get; }

        protected Mammal(string name, string type, double weight, string livingRegion)

            : base(name, type, weight)
        {
            LivingRegion = livingRegion;
        }
    }
}