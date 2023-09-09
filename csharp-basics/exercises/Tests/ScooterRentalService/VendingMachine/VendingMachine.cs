using VendingMachine.Exeption;

namespace VendingMachine
{
	public class Vending_Machine : IVendingMachine
	{

        private readonly string _manufacturer;
        private List<Product> _products = new List<Product>();
        private Money _currentAmount;
        private readonly List<decimal> validCoins = new List<decimal> { 0.10m, 0.20m, 0.50m, 1.00m, 2.00m };

        private Money CreateMoneyFromDecimal(decimal amount)
        {
            if (amount < 0)
                throw new NegativeAmountException();

            int euros = (int)amount;
            int cents = (int)((amount - euros) * 100);

            if (cents > 99)
                throw new InvalidCentsValueException();

            return new Money
            {
                Euros = euros,
                Cents = cents
            };
        }

        public Vending_Machine(string manufacturer)
        {
            _manufacturer = manufacturer;
            _currentAmount = CreateMoneyFromDecimal(0.00m);
        }

        public string Manufacturer => _manufacturer;

        public bool HasProducts => _products.Any();

        public Money Amount => _currentAmount;

        public Product[] Products => _products.ToArray();

        public bool AddProduct(string name, Money price, int count)
        {
            Console.WriteLine($"Adding product {name} with count {count}...");

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new InvalidProductNameException("Product name cannot be empty or whitespace.");
            }

            if (count < 0)
            {
                throw new InvalidProductCountException("Product count cannot be negative.");
            }

            if (price.Euros < 0 || price.Cents < 0)
            {
                throw new NegativeProductPriceException("Product price cannot be negative.");
            }

            var existingProduct = _products.FirstOrDefault(p => p.Name == name);

            if (!existingProduct.Equals(default(Product)))
            {
                if (existingProduct.Available + count > 10000)
                {
                    throw new ProductAvailabilityExceededException("The product count exceeds the allowed limit.");
                }

                existingProduct.Price = price;
                existingProduct.Available += count;
            }
            else
            {
                existingProduct = new Product
                {
                    Name = name,
                    Price = price,
                    Available = count
                };

                try
                {
                    _products.Add(existingProduct);
                }
                catch
                {
                    throw new ProductAdditionFailedException("Failed to add the product to the collection.");
                }
            }

            return true;
        }

        public Money InsertCoin(Money amount)
        {
            decimal insertedAmount = amount.Euros + (amount.Cents / 100.0m);

            if (!validCoins.Contains(insertedAmount))
            {
                throw new InvalidCoinException($"The coin of {amount.Euros}.{amount.Cents} is not valid.");
            }

            _currentAmount.Euros += amount.Euros;
            _currentAmount.Cents += amount.Cents;

            if (_currentAmount.Cents >= 100)
            {
                _currentAmount.Euros += _currentAmount.Cents / 100;
                _currentAmount.Cents %= 100;
            }

            return CreateMoneyFromDecimal(0.00m);
        }

        public Money ReturnMoney()
        {
            if (_currentAmount.Euros < 0 || _currentAmount.Cents < 0)
            {
                throw new NegativeValueException("Current amount has negative values.");
            }

            var returnedAmount = _currentAmount;
            _currentAmount = CreateMoneyFromDecimal(0.00m);
            return returnedAmount;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            const int MAX_STOCK_LIMIT = 100;

            if (productNumber < 0 || productNumber >= _products.Count)
            {
                throw new InvalidProductNumberException("Provided product number is out of range.");
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Product name cannot be null or empty.");
            }

            if (price.HasValue && (price.Value.Euros < 0 || price.Value.Cents < 0))
            {
                throw new NegativeProductPriceException("Product price cannot be negative.");
            }

            if (price.HasValue && (price.Value.Cents > 99))
            {
                throw new InvalidCentsValueException("Cents cannot be more than 99.");
            }

            if (amount < 0)
            {
                throw new ArgumentException("Product amount cannot be negative.");
            }

            if (amount > MAX_STOCK_LIMIT)
            {
                throw new ExcessiveStockException($"Product amount cannot exceed {MAX_STOCK_LIMIT}.");
            }

            var product = _products[productNumber];
            product.Name = name;

            if (price.HasValue)
            {
                product.Price = price.Value;
            }

            product.Available = amount;
            _products[productNumber] = product;

            return true;
        }

        public object GetProduct()
        {
            return _products.ToList();
        }
    }
}