using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Sku { get; set; }
        public string BuyPrice { get; set; }
        public string RegularPrice { get; set; }
        public string SalePrice { get; set; }
        public int StockQuantity { get; set; }
        public List<WebCategory> Categories { get; set; }
        public List<string> Tags { get; set; }
        public List<WebProductImage> Images { get; set; }
        public List<WebProductAttribute> Attributes { get; set; }
        public List<int> Variations { get; set; }
    }
    public class WebProductImage
    {
        public int Id { get; set; }
        public string Src { get; set; }
        public string Name { get; set; }
        public string Alt { get; set; }
    }
    public class WebProductAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public bool Visible { get; set; }
        public bool Variation { get; set; }
        public List<string> Options { get; set; }
    }
    public class WebProductVariation
    {
        public int Id { get; set; }
        public string Price { get; set; }
        public string RegularPrice { get; set; }
        public string SalePrice { get; set; }
        public int StockQuantity { get; set; }
        public string StockStatus { get; set; }
        public bool OnSale { get; set; }
        public bool ManageStock { get; set; }
    }
}
