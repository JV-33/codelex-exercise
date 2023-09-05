using Hierarchy;

[TestClass]
public class ZebraTests
{
    [TestMethod]
    public void MakeSound_PrintsCorrectSoundToConsole()
    {
        var zebra = new Zebra("Zoe", 100.5, "Savannah");
        using var stringWriter = new System.IO.StringWriter();
        Console.SetOut(stringWriter);

        zebra.MakeSound();

        var expected = "zebra" + Environment.NewLine;
        Assert.AreEqual(expected, stringWriter.ToString());
    }

    [TestMethod]
    public void Eat_WhenGivenVegetable_IncrementsFoodEatenAndPrintsMessage()
    {
        var zebra = new Zebra("Zoe", 100.5, "Savannah");
        var vegetable = new Vegetable(7);
        using var stringWriter = new System.IO.StringWriter();
        Console.SetOut(stringWriter);

        zebra.Eat(vegetable);

        var expectedOutput = "Zebra eating grass" + Environment.NewLine;
        Assert.AreEqual(7, zebra.FoodEaten);
        Assert.AreEqual(expectedOutput, stringWriter.ToString());
    }

    [TestMethod]
    public void Eat_WhenGivenNonVegetable_PrintsNotEatingMessage()
    {
        var zebra = new Zebra("Zoe", 100.5, "Savannah");
        var meat = new Meat(5);
        using var stringWriter = new System.IO.StringWriter();
        Console.SetOut(stringWriter);

        zebra.Eat(meat);

        var expected = "Zebra are not eating that type of food!" + Environment.NewLine;
        Assert.AreEqual(0, zebra.FoodEaten); 
        Assert.AreEqual(expected, stringWriter.ToString());
    }
}
