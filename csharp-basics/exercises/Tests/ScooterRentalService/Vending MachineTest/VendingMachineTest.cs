using VendingMachine;

namespace VendingMachineTests
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void TestCreateMoneyFromDecimal()
        {
            var vendingMachine = new Vending_Machine("Test Manufacturer");

            var method = typeof(Vending_Machine).GetMethod("CreateMoneyFromDecimal", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            var result = (Money)method.Invoke(vendingMachine, new object[] { 2.35m });

            Assert.AreEqual(2, result.Euros);
            Assert.AreEqual(35, result.Cents);
        }

        [TestMethod]
        public void AddProduct_AddsNewProductSuccessfully()
        {
            // Arrange
            var vendingMachine = new Vending_Machine("SomeManufacturer");
            var productPrice = new Money { Euros = 1, Cents = 50 }; // €1.50

            // Act
            bool result = vendingMachine.AddProduct("Soda", productPrice, 10);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(vendingMachine.HasProducts);
            Assert.AreEqual(1, vendingMachine.Products.Length);
            Assert.AreEqual("Soda", vendingMachine.Products.First().Name);
            Assert.AreEqual(productPrice.Euros, vendingMachine.Products.First().Price.Euros);
            Assert.AreEqual(productPrice.Cents, vendingMachine.Products.First().Price.Cents);
            Assert.AreEqual(10, vendingMachine.Products.First().Available);

        }

    }
}
