using System.ComponentModel.DataAnnotations;

namespace OnLineOrder.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductName  { get; set; }
        [Required]
        [MaxLength(50)]
        public string ProductDescription { get; set; }
        [Required]
         public decimal Price { get; set; }

    }
}
