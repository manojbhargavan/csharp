using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public long Quantity { get; set; }
        public double? PurchasePrice { get; set; }
        
        public bool Validate() => true;

        public OrderItem Retrive(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrive()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
