using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", 70.00, 14);
            Product iphone = new Product("iPhone 5s", 999.99, 3);
            Product epson = new Product("Epson EB-U05", 440.46, 1);

            iphone.PrintProduct();
            mouse.PrintProduct();
            epson.PrintProduct();
            
            iphone.ChangePrice(888.01);
            iphone.ChangeQuantity(7);
            Console.WriteLine("\nAfter updates:");
            iphone.PrintProduct();

            Console.ReadKey();

        }
    }

    class Product
    {
        private string _name;
        private double _priceAtStart;
        private int _amountAtStart;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _priceAtStart = priceAtStart;
            _amountAtStart = amountAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, {_priceAtStart} EUR, {_amountAtStart} units");
        }

        public void ChangeQuantity(int newAmount)
        {
            _amountAtStart = newAmount;
        }

        public void ChangePrice(double  newPrice)
        {
            _priceAtStart = newPrice;
        }
    }

 
}
