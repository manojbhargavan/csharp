using System;

namespace EventHandling.OrderExample.Model
{
    public class OrderEventArgs : EventArgs
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public decimal DiscountedTotal { get; set; }
    }
}
