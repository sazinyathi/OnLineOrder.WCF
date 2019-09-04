using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnLineOrder.Models
{
    [Table("OrderItems")]
    public class OrderItems
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Orders Orders { get; set; }
        public Product Product { get; set; }

    }
}
