using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPICoreEx.Models
{       [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CId { get; set; }
        [MaxLength(50)]
        [Required]
        public string CName{ get; set; }
        [MaxLength(50)]
        [Required]
        public string CCity { get; set; }
        public double  CODLimit { get; set; }
    }
}
