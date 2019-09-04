using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnLineOrder.Models
{
    public class Login
    {
        [Required]
        [Key]
        public int LoginId { get; set; }
        [Required]
        [MaxLength(10)]
        public string  Username { get; set; }
        [Required]
        [MaxLength(10)]
        public string Password { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
    }
}
