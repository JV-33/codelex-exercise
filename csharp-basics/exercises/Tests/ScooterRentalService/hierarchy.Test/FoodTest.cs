using Hierarchy.Exeption;

namespace Hierarchy.Test;

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

    [TestMethod]
    [ExpectedException(typeof(UnknownFoodException))]
    public void CreateFood_WithUnknownInput_ThrowsUnknownFoodException()
    {
        string input = "Fruit 5";

        Food.CreateFood(input);
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void CreateFood_WithInvalidQuantity_ThrowsFormatException()
    {
        string input = "Meat Five";

        Food.CreateFood(input);
    }

    [TestMethod]
    [ExpectedException(typeof(IndexOutOfRangeException))]
    public void CreateFood_WithIncompleteInput_ThrowsIndexOutOfRangeException()
    {
        string input = "Meat";

        Food.CreateFood(input);
    }
}