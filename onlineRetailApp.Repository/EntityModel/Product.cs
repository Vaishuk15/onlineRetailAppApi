
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace OnlineRetailApp.Repository.EntityModel
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [MinLength(3), MaxLength(15)]


        public string ProductName { get; set; }
        [Range(3,15)]
        public int AvailableQuantity { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Column(TypeName = "decimal(12,3)")]
        public decimal UnitPrice { get; set; }

    }
}
