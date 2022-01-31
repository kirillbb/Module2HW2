using System;
using System.Collections.Generic;

namespace Module2HW2
{
    public static class Shop
    {
        public static void Run()
        {
            Console.WriteLine("Product list:\n");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Index} ___ {product.Name} - {product.Price}$");
            }

            AddProductsToBasket();

            Console.WriteLine($"In your shopping basket products for {Calculate.TotalPrice(Basket.BasketList)}$");
        }

        private static void AddProductsToBasket()
        {
            Console.WriteLine("How many items would you like to purchase?");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int count))
            {
                Console.WriteLine($"Adding {count} items to shopping basket...");
            }
            else
            {
                Console.WriteLine("Incorrect input, use digits, try again!");
            }

            Random random = new();

            for (int i = 0; i < count; i++)
            {
                int item = random.Next(0, 18);
                Basket.BasketList.Add(products[item]);
                Console.WriteLine($"{products[item].Index} ___ " +
                    $"{products[item].Name} - " +
                    $"{products[item].Price}$");
            }

        }

        private static readonly List<Product> products = new()
        {
            new(101,"Tomato", 12),
            new(102, "Pineapple", 45),
            new(103, "Carrot", 5),
            new(104, "Pepsi", 7),
            new(105, "Snickers", 5),
            new(106, "Juice", 20),
            new(107, "Bread", 8),
            new(108, "Fanta", 8),
            new(109, "7up", 7),
            new(110, "Marlboro", 25),
            new(111, "Beer", 10),
            new(112, "Aspirine", 7),
            new(113, "IceCream", 4),
            new(114, "JackDaniels", 99),
            new(115, "Heets", 27),
            new(116, "Meat", 30),
            new(117, "Butter", 15),
            new(118, "Sauce", 12)
        };
    }
}