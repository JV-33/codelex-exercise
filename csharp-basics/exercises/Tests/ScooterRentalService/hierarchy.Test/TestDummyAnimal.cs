using Hierarchy;

public class TestAnimal : Animal
{
    public TestAnimal(string name, string type, double weight) 
        : base(name, type, weight) { }

    public override void MakeSound() 
    {
        // Implementation for test
    }

    public override void Eat(Food food)
    {
        // Implementation for test
    }
}
