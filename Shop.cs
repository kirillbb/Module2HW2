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
                Console.WriteLine($"{product.Index} : {product.Name} - {product.Price}");
            }
        }

        private static readonly List<Product> products = new()
        {
            new(1,"Tomato", 12),
            new(2, "Pineapple", 45),
            new(3, "Carrot", 5),
            new(4, "Pepsi", 7),
            new(5, "Snickers", 5),
            new(6, "Juice", 20),
            new(7, "Bread", 8),
            new(8, "Fanta", 8),
            new(9, "7up", 7),
            new(10, "Marlboro", 25),
            new(11, "Beer", 10),
            new(12, "Aspirine", 7),
            new(13, "IceCream", 4),
            new(14, "JackDaniels", 99),
            new(15, "Heets", 27),
            new(16, "Meat", 30),
            new(17, "Butter", 15),
            new(18, "Sauce", 12)
        };
    }
}