using System;
using System.ComponentModel.DataAnnotations;

namespace SR3POS.Models
{
    public class Unit
    {
        [Key]
        public Guid UnitId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Unit Name")]
        public string UnitName { get; set; }
        public int Qty { get; set; }
    }
}
