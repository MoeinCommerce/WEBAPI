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
        public string Subtotal { get; set; }
        public string SubtotalTax { get; set; }
        public string Total { get; set; }
        public string TotalTax { get; set; }
    }
}