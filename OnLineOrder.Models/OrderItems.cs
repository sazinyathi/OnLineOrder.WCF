using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnLineOrder.Models
{
    public class OrderItems
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }

    }
}
