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
        public string Description { get; set; }
        public string Sku { get; set; }
        public decimal? BuyPrice { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int StockQuantity { get; set; }
        public List<WebCategory> Categories { get; set; }
        public string IconPath { set; get; }
        public string Type { get; set; }
        public List<Attribute> Attributes { get; set; }

    }
    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
