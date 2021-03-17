

using System;

namespace OnlineRetailApp.Models.ViewModel
{
    public class ProductViewModel
    {
        //public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
       /* public DateTime CreatedDate { get; set; } *//*= DateTime.UtcNow;*/

       /* public DateTime UpdatedDate { get; set; } *//*=  DateTime.UtcNow;*/
        public decimal UnitPrice { get; set; }


    }
}
