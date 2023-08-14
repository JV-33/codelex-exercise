using System;
using System;
using System.Collections.Generic;

namespace Exercise_13
{
	public class Smoothie
	{
		public List<string> Ingredients { get; private set; }

		private Dictionary<string, double> _ingredientPrices = new Dictionary<string, double>
		{
			{ "Strawberries", 1.50 },
			{ "Banana", 0.50 },
			{ "Mango", 2.50 },
			{ "Blueberries", 1.00 },
			{ "Raspberries", 1.00 },
			{ "Apple", 1.75 },
			{ "Pineapple", 3.50 }
		};

        public Smoothie(string[] ingredients)
		{
            Ingredients = ingredients.ToList();
        }

		public string GetCost()
		{
			double totalCost = Ingredients.Sum(ingredient => _ingredientPrices[ingredient]);
			return $"£{totalCost:F2}";
		}

		public string GetPrice()
		{
			double cost = double.Parse(GetCost().Substring(1));
            double price = cost + (cost * 1.5);
			return $"£{price:  F2}";
		}

		public string GetName()
		{
            List<string> sortedIngredients = Ingredients.OrderBy(i => i).ToList();
            for (int i = 0; i < sortedIngredients.Count; i++)
            {
                if (sortedIngredients[i].EndsWith("berries"))
                {
                    sortedIngredients[i] = sortedIngredients[i].Replace("berries", "berry");
                }
            }

			string name = string.Join(" ", sortedIngredients);
			if (Ingredients.Count > 1)
			{
				name += " Fusion";
			}
			else
			{
				name += " Smoothie";
			}

			return name;
		}
	}
}

