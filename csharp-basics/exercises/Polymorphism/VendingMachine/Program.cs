﻿using System;
using VendingMachine;

internal class Program
{
    private static VendingMachine.VendingMachine vendingMachine = new VendingMachine.VendingMachine("ACME Vending Co.");

    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    InsertCoin();
                    break;

                case "2":
                    ReturnMoney();
                    break;

                case "3":
                    AddProduct();
                    break;

                case "4":
                    UpdateProduct();
                    break;

                case "5":
                    ShowProducts();
                    break;

                case "6":
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Vending Machine Menu:");
        Console.WriteLine("1. Insert Coin");
        Console.WriteLine("2. Return Money");
        Console.WriteLine("3. Add Product");
        Console.WriteLine("4. Update Product");
        Console.WriteLine("5. Show Products");
        Console.WriteLine("6. Exit");
    }

    private static void InsertCoin()
    {
        Console.WriteLine("Insert Coin (e.g., 1.00 for 1 Euro): ");
        var moneyInput = Console.ReadLine().Split('.');
        var coin = new Money { Euros = int.Parse(moneyInput[0]), Cents = int.Parse(moneyInput[1]) };
        var returned = vendingMachine.InsertCoin(coin);
        if (returned.Euros == 0 && returned.Cents == 0)
            Console.WriteLine("Coin accepted.");
        else
            Console.WriteLine($"Coin of {returned.Euros}.{returned.Cents} returned.");
    }

    private static void ReturnMoney()
    {
        var returnedMoney = vendingMachine.ReturnMoney();
        Console.WriteLine($"Returned {returnedMoney.Euros}.{returnedMoney.Cents}");
    }

    private static void AddProduct()
    {
        Console.WriteLine("Enter product name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter product price (e.g., 1.00 for 1 Euro):");
        var priceInput = Console.ReadLine().Split('.');
        var price = new Money { Euros = int.Parse(priceInput[0]), Cents = int.Parse(priceInput[1]) };
        Console.WriteLine("Enter product amount:");
        var count = int.Parse(Console.ReadLine());
        if (vendingMachine.AddProduct(name, price, count))
            Console.WriteLine("Product added.");
        else
            Console.WriteLine("Failed to add product.");
    }

    private static void UpdateProduct()
    {
        Console.WriteLine("Enter product number to update:");
        var productNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter new product name (or leave blank):");
        var newName = Console.ReadLine();
        Console.WriteLine("Enter new product price (or leave blank):");
        var newPriceInput = Console.ReadLine();
        Money? newPrice = string.IsNullOrEmpty(newPriceInput) ? null : (Money?)new Money { Euros = int.Parse(newPriceInput.Split('.')[0]), Cents = int.Parse(newPriceInput.Split('.')[1]) };
        Console.WriteLine("Enter amount to add/subtract:");
        var amount = int.Parse(Console.ReadLine());
        if (vendingMachine.UpdateProduct(productNumber, newName, newPrice, amount))
            Console.WriteLine("Product updated.");
        else
            Console.WriteLine("Failed to update product.");
    }

    private static void ShowProducts()
    {
        Console.WriteLine("Available Products:");
        var products = vendingMachine.Products;
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i}. {products[i].Name} - {products[i].Price.Euros}.{products[i].Price.Cents} (Available: {products[i].Available})");
        }
    }
}