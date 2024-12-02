namespace WebApi.Models
{
    public class WebOrderDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public int VariationId { get; set; }
        public int Quantity { get; set; }
        public string TaxClass { get; set; }
        public double Subtotal { get; set; }
        public double SubtotalTax { get; set; }
        public double TotalTax { get; set; }
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