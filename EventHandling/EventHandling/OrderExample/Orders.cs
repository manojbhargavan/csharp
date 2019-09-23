using EventHandling.OrderExample.Model;
using System;
using System.Collections.Generic;

namespace EventHandling.OrderExample
{
    public class Orders
    {
        public event EventHandler<OrderEventArgs> OrderPlaced;
        public event EventHandler<OrderEventArgs> OrderCancelled;
        public List<Order> Order { get; private set; }

        public Orders()
        {
            Order = new List<Order>
            {
                new Order { CustomerId = 1, ItemName = "Pen", OrderId = 1, SubTotal = 10M},
                new Order { CustomerId = 1, ItemName = "Ink", OrderId = 1, SubTotal = 20M},
                new Order { CustomerId = 1, ItemName = "Book", OrderId = 1, SubTotal = 30M},
                new Order { CustomerId = 1, ItemName = "Bag", OrderId = 1, SubTotal = 40M},
                new Order { CustomerId = 1, ItemName = "Coat", OrderId = 1, SubTotal = 50M}
            };
        }

        public void ProcessOrder()
        {
            //Something
            OnOrderPlaced();
        }

        protected virtual void OnOrderPlaced()
        {
            decimal total = 0.0M;
            foreach (var item in Order)
            {
                total += item.SubTotal;
            }
            OrderPlaced(this, new OrderEventArgs
            {
                OrderId = 1,
                Total = total,
                DiscountedTotal = GetDiscountedTotal(total)
            });
        }

        private decimal GetDiscountedTotal(decimal total)
        {
            return Order.Count > 3 ? total * 0.85M : total * 0.90M;
        }
    }
}
