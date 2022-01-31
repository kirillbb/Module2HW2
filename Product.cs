using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Product
    {
        public int Index { get; }
        public string Name { get; }
        public int Price { get; }

        public Product(int index, string name, int price)
        {
            Index = index;
            Name = name;
            Price = price;

        }
    }
}
