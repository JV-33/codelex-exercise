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
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var productName = "Soda";
            var productPrice = new Money { Euros = 1, Cents = 0 };
            var productCount = 10;

            var result = vendingMachine.AddProduct(productName, productPrice, productCount);

            Assert.IsTrue(result, "Expected product to be added successfully");
            Assert.IsTrue(vendingMachine.HasProducts, "Expected vending machine to have products");
        }


        [TestMethod]
        public void InsertCoin_ValidCoin_ShouldUpdateAmount()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialAmount = vendingMachine.Amount;
            var coin = new Money { Euros = 1, Cents = 0 };

            var result = vendingMachine.InsertCoin(coin);

            Assert.AreEqual(initialAmount.Euros + coin.Euros, vendingMachine.Amount.Euros);
            Assert.AreEqual(initialAmount.Cents + coin.Cents, vendingMachine.Amount.Cents);
        }

        [TestMethod]
        public void InsertCoin_InvalidCoin_ShouldNotUpdateAmount()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialAmount = vendingMachine.Amount;
            var coin = new Money { Euros = 0, Cents = 99 };  // Invalid coin

            var result = vendingMachine.InsertCoin(coin);

            Assert.AreEqual(initialAmount.Euros, vendingMachine.Amount.Euros);
            Assert.AreEqual(initialAmount.Cents, vendingMachine.Amount.Cents);
        }

        [TestMethod]
        public void UpdateProduct_WithValidData_UpdatesProductSuccessfully()
        {
            // Arrange
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialProduct = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            vendingMachine.AddProduct(initialProduct.Name, initialProduct.Price, initialProduct.Available);

            var newName = "Coke";
            var newPrice = new Money { Euros = 2, Cents = 0 };
            var newAmount = 10;

            // Act
            var result = vendingMachine.UpdateProduct(0, newName, newPrice, newAmount);

            // Assert
            Assert.IsTrue(result, "Expected product to be updated successfully");
            var updatedProducts = (List<Product>)vendingMachine.GetProduct();
            var updatedProduct = updatedProducts[0];
            Assert.AreEqual(newName, updatedProduct.Name);
            Assert.AreEqual(newPrice, updatedProduct.Price);
            Assert.AreEqual(newAmount, updatedProduct.Available);
        }

        // Add more test methods to cover other scenarios:
        // - Invalid product number
        // - Update only name, only price, only amount
        // - Other edge cases you can think of

        [TestMethod]
        public void GetProduct_ReturnsCorrectListOfProducts()
        {
            // Arrange
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var product1 = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            var product2 = new Product { Name = "Water", Price = new Money { Euros = 0, Cents = 50 }, Available = 10 };

            vendingMachine.AddProduct(product1.Name, product1.Price, product1.Available);
            vendingMachine.AddProduct(product2.Name, product2.Price, product2.Available);

            // Act
            var products = vendingMachine.GetProduct() as List<Product>;
            Assert.IsNotNull(products, "Expected a valid list of products");

            // Assert
            Assert.AreEqual(2, products.Count);  // Check if there are 2 products
            Assert.AreEqual(product1.Name, products[0].Name);  // Check if the first product is correct
            Assert.AreEqual(product2.Name, products[1].Name);  // Check if the second product is correct
        }


    }


}
