using System.IO;
using Hierarchy;

namespace hierarchy.Test
{
	public class TigerTest
	{
        [TestMethod]
        public void MakeSound_PrintsCorrectSoundToConsole()
        {
            var tiger = new Tiger("Rajah", 250.5, "Jungle");
            using var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            tiger.MakeSound();

            var expected = "ROAAR!!!" + Environment.NewLine;
            Assert.AreEqual(expected, stringWriter.ToString());
        }

        [TestMethod]
        public void Eat_WhenGivenMeat_IncrementsFoodEatenByMeatQuantity()
        {
            var tiger = new Tiger("Rajah", 250.5, "Jungle");
            var meat = new Meat(5);

            tiger.Eat(meat);

            Assert.AreEqual(5, tiger.FoodEaten);
        }

        [TestMethod]
        public void Eat_WhenGivenNonMeat_PrintsAppropriateMessageToConsole()
        {
            var tiger = new Tiger("Rajah", 250.5, "Jungle");
            var vegetable = new Vegetable(5);
            using var stringWriter = new System.IO.StringWriter();
            Console.SetOut(stringWriter);

            tiger.Eat(vegetable);

            var expected = "Tigers are not eating that type of food!" + Environment.NewLine;
            Assert.AreEqual(expected, stringWriter.ToString());
        }
    }
}

