using System.ComponentModel.DataAnnotations;

namespace OnLineOrder.Models
{
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
        public Login MyProperty { get; set; }

    }
}
