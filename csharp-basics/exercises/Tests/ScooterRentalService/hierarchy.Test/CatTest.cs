namespace Hierarchy.Test
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void TestMakeSound()
        {
            var cat = new Cat("Muris", 5.5, "Brown", "Siamese");
            var expectedOutput = "mjau mjau maju" + Environment.NewLine;
            string actualOutput;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                cat.MakeSound();
                actualOutput = sw.ToString();
            }

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestEatMethod()
        {
            var cat = new Cat("Muris", 5.5, "Brown", "Siamese");
            var food = new Meat(3);

            var expectedOutput = "omes desu" + Environment.NewLine;
            string actualOutput;

            int initialFoodEaten = cat.FoodEaten;
            int expectedFoodEatenAfterEating = initialFoodEaten + food.Quantity;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                cat.Eat(food);
                actualOutput = sw.ToString();
            }

            Assert.AreEqual(expectedOutput, actualOutput); 
            Assert.AreEqual(expectedFoodEatenAfterEating, cat.FoodEaten);
        }
    }
}