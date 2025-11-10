using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Price
    {
        public long Id { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int PriceLevelId { get; set; }
        public PriceLevel PriceLevel { get; set; }
    }
    public class PriceLevel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
