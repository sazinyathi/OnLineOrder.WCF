using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnLineOrder.Models
{
    [Table("Products")]
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
