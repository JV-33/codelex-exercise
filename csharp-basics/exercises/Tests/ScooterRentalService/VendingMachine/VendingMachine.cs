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

            if (string.IsNullOrWhiteSpace(name) || count < 0)
            {
                Console.WriteLine($"Failed to add product {name}: Invalid name or count.");
                return false;
            }

            var existingProduct = _products.FirstOrDefault(p => p.Name == name);

            if (!existingProduct.Equals(default(Product)))

            {
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

                _products.Add(existingProduct);
            }

            return true;
        }


        public Money InsertCoin(Money amount)
        {
            decimal insertedAmount = amount.Euros + (amount.Cents / 100.0m);

            if (!validCoins.Contains(insertedAmount))
            {
                return amount; 
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
            var returnedAmount = _currentAmount;
            _currentAmount = CreateMoneyFromDecimal(0.00m);
            return returnedAmount;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber >= _products.Count)
            {
                return false; 
            }

            var product = _products[productNumber];
            if (!string.IsNullOrEmpty(name))
            {
                product.Name = name;
            }

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

