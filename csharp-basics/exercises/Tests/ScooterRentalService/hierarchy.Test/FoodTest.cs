namespace Hierarchy;

[TestClass]
public class FoodTests
{
    [TestMethod]
    public void CreateFood_WithMeatInput_ReturnsMeatObjectWithCorrectQuantity()
    {
        string input = "Meat 5";

        var food = Food.CreateFood(input);

        Assert.IsNotNull(food);
        Assert.IsInstanceOfType(food, typeof(Meat));
        Assert.AreEqual(5, food.Quantity);
    }

    [TestMethod]
    public void CreateFood_WithVegetableInput_ReturnsVegetableObjectWithCorrectQuantity()
    {
        string input = "Vegetable 3";

        var food = Food.CreateFood(input);

        Assert.IsNotNull(food);
        Assert.IsInstanceOfType(food, typeof(Vegetable));
        Assert.AreEqual(3, food.Quantity);
    }

    // Šeit var pievienot vairāk testu, piemēram, testējot nezināmus pārtikas tipus vai nepareizi formatētu ievadi.
}
