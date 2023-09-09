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
        [ExpectedException(typeof(VendingMachine.Exeption.InvalidCoinException))]
        public void InsertCoin_InvalidCoin_ShouldThrowInvalidCoinException()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var coin = new Money { Euros = 0, Cents = 99 };

            vendingMachine.InsertCoin(coin);
        }

        [TestMethod]
        public void UpdateProduct_WithValidData_UpdatesProductSuccessfully()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialProduct = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            vendingMachine.AddProduct(initialProduct.Name, initialProduct.Price, initialProduct.Available);

            var newName = "Coke";
            var newPrice = new Money { Euros = 2, Cents = 0 };
            var newAmount = 10;

            var result = vendingMachine.UpdateProduct(0, newName, newPrice, newAmount);

            Assert.IsTrue(result, "Expected product to be updated successfully");
            var updatedProducts = (List<Product>)vendingMachine.GetProduct();
            var updatedProduct = updatedProducts[0];
            Assert.AreEqual(newName, updatedProduct.Name);
            Assert.AreEqual(newPrice, updatedProduct.Price);
            Assert.AreEqual(newAmount, updatedProduct.Available);
        }

        [TestMethod]
        [ExpectedException(typeof(VendingMachine.Exeption.InvalidProductNumberException))]
        public void UpdateProduct_InvalidProductNumber_ShouldThrowException()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var result = vendingMachine.UpdateProduct(-1, "NewName", new Money { Euros = 2, Cents = 0 }, 10);
        }

        [TestMethod]
        public void UpdateProduct_OnlyName_UpdatesSuccessfully()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialProduct = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            vendingMachine.AddProduct(initialProduct.Name, initialProduct.Price, initialProduct.Available);

            var newName = "Coke";
            var result = vendingMachine.UpdateProduct(0, newName, null, 5);

            var updatedProducts = (List<Product>)vendingMachine.GetProduct();
            var updatedProduct = updatedProducts[0];
            Assert.IsTrue(result);
            Assert.AreEqual(newName, updatedProduct.Name);
            Assert.AreEqual(initialProduct.Price, updatedProduct.Price);
            Assert.AreEqual(initialProduct.Available, updatedProduct.Available);
        }

        [TestMethod]
        public void UpdateProduct_OnlyPrice_UpdatesSuccessfully()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialProduct = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            vendingMachine.AddProduct(initialProduct.Name, initialProduct.Price, initialProduct.Available);

            var newPrice = new Money { Euros = 2, Cents = 0 };
            var result = vendingMachine.UpdateProduct(0, "Soda", newPrice, 5);

            var updatedProducts = (List<Product>)vendingMachine.GetProduct();
            var updatedProduct = updatedProducts[0];
            Assert.IsTrue(result);
            Assert.AreEqual(initialProduct.Name, updatedProduct.Name);
            Assert.AreEqual(newPrice, updatedProduct.Price);
            Assert.AreEqual(initialProduct.Available, updatedProduct.Available);
        }

        [TestMethod]
        public void UpdateProduct_OnlyAmount_UpdatesSuccessfully()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialProduct = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            vendingMachine.AddProduct(initialProduct.Name, initialProduct.Price, initialProduct.Available);

            var newAmount = 10;
            var result = vendingMachine.UpdateProduct(0, "Soda", null, newAmount);

            var updatedProducts = (List<Product>)vendingMachine.GetProduct();
            var updatedProduct = updatedProducts[0];
            Assert.IsTrue(result);
            Assert.AreEqual(initialProduct.Name, updatedProduct.Name);
            Assert.AreEqual(initialProduct.Price, updatedProduct.Price);
            Assert.AreEqual(newAmount, updatedProduct.Available);
        }

        [TestMethod]
        public void AddProduct_SameNameDifferentCase_TreatsAsDifferentProducts()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var initialProduct = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            vendingMachine.AddProduct(initialProduct.Name, initialProduct.Price, initialProduct.Available);
            vendingMachine.AddProduct("soda", new Money { Euros = 2, Cents = 0 }, 7);

            var products = vendingMachine.GetProduct() as List<Product>;

            Assert.AreEqual(2, products.Count, "Expected two different products");
        }

        [TestMethod]
        public void GetProduct_ReturnsCorrectListOfProducts()
        {
            var vendingMachine = new Vending_Machine("TestManufacturer");
            var product1 = new Product { Name = "Soda", Price = new Money { Euros = 1, Cents = 0 }, Available = 5 };
            var product2 = new Product { Name = "Water", Price = new Money { Euros = 0, Cents = 50 }, Available = 10 };

            vendingMachine.AddProduct(product1.Name, product1.Price, product1.Available);
            vendingMachine.AddProduct(product2.Name, product2.Price, product2.Available);

            var products = vendingMachine.GetProduct() as List<Product>;
            Assert.IsNotNull(products, "Expected a valid list of products");

            Assert.AreEqual(2, products.Count);
            Assert.AreEqual(product1.Name, products[0].Name);
            Assert.AreEqual(product2.Name, products[1].Name);
        }
    }
}