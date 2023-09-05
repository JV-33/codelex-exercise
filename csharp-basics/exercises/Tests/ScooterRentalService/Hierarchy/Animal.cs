using Hierarchy;

public abstract class Animal
{
    public string AnimalName { get; }
    public string AnimalType { get; }
    public double AnimalWeight { get; }
    public int FoodEaten { get; protected set; }

    protected Animal(string name, string type, double weight)
    {
        AnimalName = name;
        AnimalType = type;
        AnimalWeight = weight;
    }

    public abstract void MakeSound();
    public abstract void Eat(Food food);

    public override string ToString()
    {
        return $"{GetType().Name}[{AnimalName}, {AnimalType}, {AnimalWeight.ToString("F2")}, {FoodEaten}]";
    }
}
