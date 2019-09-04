using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnLineOrder.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Required]
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Surname { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public List<Login> Login { get; set; }

    }
}
