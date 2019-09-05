using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineOrder.Models
{
    [Table("LoginSession")]
   public class LoginSession
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(40)]
        public string  SessionKey { get; set; }
        [Required]
        public DateTime SessionStart { get; set; }
        [Required]
        public DateTime SessionLastAction{ get; set; }
        [Required]
        public DateTime RowCreateDate { get; set; }
        [Required]
        public DateTime RowLastUpdateDate { get; set; }
        [Required]
        [MaxLength(40)]
        public string SessionId { get; set; }
        [ForeignKey("Login")]
        public int LoginId { get; set; }
    }           
}
