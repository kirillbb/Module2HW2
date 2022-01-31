using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public static class Calculate
    {
        public static int TotalPrice(List<Product> products)
        {
            int totalPrice = 0;

            foreach (var item in products)
            {
                totalPrice += item.Price;
            }

           return totalPrice;
        }
    }
}
