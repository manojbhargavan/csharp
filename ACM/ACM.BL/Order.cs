using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {
            return OrderDate != null;
        }

        public Order Retrive(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrive()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
