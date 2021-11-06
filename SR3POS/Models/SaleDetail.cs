using System;
using System.ComponentModel.DataAnnotations;

namespace SR3POS.Models
{
    public class SaleDetail
    {
        [Key]
        public Guid SaleDetailId { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
    }
}
