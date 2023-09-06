namespace Hierarchy.Test
{
	public class MouseTest
	{
    [TestMethod]
    public void MakeSound_PrintsCorrectSoundToConsole()
    {
        var animal = new Mouse("Mickey", "Mouse", 0.5, "House");
            using var stringWriter = new System.IO.StringWriter();
        Console.SetOut(stringWriter);

        animal.MakeSound();

        var expected = "pee pee pee" + Environment.NewLine;
        Assert.AreEqual(expected, stringWriter.ToString());
    }
	}
}