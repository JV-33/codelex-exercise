namespace Hierarchy.Test
{
    [TestClass]
    public class AnimalTest
    {
        [TestMethod]
        public void TestAnimalConstructor()
        {
            var name = "TestName";
            var type = "TestType";
            var weight = 10.0;

            var testAnimal = new TestDummyAnimal(name, type, weight);

            Assert.AreEqual(name, testAnimal.AnimalName);
            Assert.AreEqual(type, testAnimal.AnimalType);
            Assert.AreEqual(weight, testAnimal.AnimalWeight);
            Assert.AreEqual(0, testAnimal.FoodEaten);
        }

        /*[TestMethod]
        public void TestAnimalToString()
        {
            var testAnimal = new TestAnimal("Name", "Type", 10.0);

            var result = testAnimal.ToString();

            Assert.AreEqual("TestAnimal[Name, Type, 10.00, 0]", result);
        }*/
    }
}