namespace EventHandling.OrderExample.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string ItemName { get; set; }
        public decimal SubTotal { get; set; }
    }
}
