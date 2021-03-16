using System;


namespace OnlineRetailApp.Models
{
    public class OrderViewModel
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        //public Guid CustomerId { get; set; }
        public int Quantity { get; set; }
        //public DateTime OrderedDate { get; set; }
        //public DateTime ShippingDate { get; set; }
        //public decimal TotalPrice { get; set; }
    }
}
