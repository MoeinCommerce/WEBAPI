using System.Numerics;

namespace WebApi.Models
{
    public class WebOrderDetail
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProductId { get; set; }
        public string VariationId { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double UnitDiscount { get; set; }
        public double UnitTax { get; set; }
        // Computational Properties
        public double SubTotal => Quantity * UnitPrice;
        public double Discount => Quantity * UnitDiscount;
        public double Tax => Quantity * UnitTax;
        public double Total => SubTotal - Discount + Tax;
    }
}