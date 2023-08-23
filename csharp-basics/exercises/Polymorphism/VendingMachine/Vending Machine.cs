using System;
using System.Linq;
using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public string Manufacturer { get; private set; }

        private List<Product> _products;
        private Money _currentAmount;

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
            _products = new List<Product>();
            _currentAmount = new Money();
        }

        public bool HasProducts => _products.Any(p => p.Available > 0);

        public Money Amount => _currentAmount;

        public Product[] Products => _products.ToArray();

        public Money InsertCoin(Money amount)
        {
            if (IsValidCoin(amount))
            {
                _currentAmount.Euros += amount.Euros;
                _currentAmount.Cents += amount.Cents;
                NormalizeMoney();
                return new Money { Euros = 0, Cents = 0 };
            }

            return amount;
        }

        public Money ReturnMoney()
        {
            var amountToReturn = _currentAmount;
            _currentAmount = new Money { Euros = 0, Cents = 0 };
            return amountToReturn;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (_products.Any(p => p.Name == name))
                return false;

            _products.Add(new Product
            {
                Name = name,
                Price = price,
                Available = count
            });

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber >= _products.Count)
                return false;

            var product = _products[productNumber];
            product.Name = name ?? product.Name;
            product.Price = price ?? product.Price;
            product.Available += amount;

            _products[productNumber] = product;

            return true;
        }

        private bool IsValidCoin(Money coin)
        {
            var validCoins = new List<Money>
            {
                new Money { Euros = 0, Cents = 10 },
                new Money { Euros = 0, Cents = 20 },
                new Money { Euros = 0, Cents = 50 },
                new Money { Euros = 1, Cents = 0 },
                new Money { Euros = 2, Cents = 0 }
            };

            return validCoins.Any(c => c.Euros == coin.Euros && c.Cents == coin.Cents);
        }

        private void NormalizeMoney()
        {
            while (_currentAmount.Cents >= 100)
            {
                _currentAmount.Euros += 1;
                _currentAmount.Cents -= 100;
            }
        }
    }
}