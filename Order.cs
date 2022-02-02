using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public class Order
    {
        private static List<Product> orderList = new ();
        public Order()
        {
            OrderStatus = true;

            Random random = new ();
            OrderNumber = random.Next(100000, 999999);
        }

        public int OrderNumber { get; private set; }
        public bool OrderStatus { get; private set; }
        internal static List<Product> OrderList { get => orderList; set => orderList = value; }
    }
}
