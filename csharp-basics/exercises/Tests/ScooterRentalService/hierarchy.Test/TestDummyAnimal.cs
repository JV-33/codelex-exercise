namespace Hierarchy.Test
{
	public class TestDummyAnimal : Animal
	{
        public TestDummyAnimal(string name, string type, double weight)
            : base(name, type, weight) { }

        public override void MakeSound()
        {
        }

        public override void Eat(Food food)
        {
        }

    }
}

