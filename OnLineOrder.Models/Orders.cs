using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnLineOrder.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Required]
        [Key]
        public int OrderId { get; set; }
        public DateTime ShipDate { get; set; }
        [Required]
        public DateTime RowCreatedDate { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}
