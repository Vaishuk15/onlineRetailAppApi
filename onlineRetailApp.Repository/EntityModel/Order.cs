using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace OnlineRetailApp.Repository.EntityModel
{
    public class Order
    {
       
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public Guid OrderId { get; set; }
            [MinLength(3), MaxLength(15)]

        
            public Guid ProductId { get; set; }
            [ForeignKey(nameof(ProductId))]
            [MinLength(3), MaxLength(15)]

            public Guid CustomerId { get; set; }
            [MinLength(3), MaxLength(15)]

            public int Quantity { get; set; }
            public DateTime OrderedDate { get; set; }

            public DateTime ShippingDate { get; set; }
            [ForeignKey(nameof(ProductId))]
            public virtual Product Product { get; set; }

        //[Column(TypeName = "decimal(12,3)")]
        //public decimal TotalPrice { get; set; }
    }
}
