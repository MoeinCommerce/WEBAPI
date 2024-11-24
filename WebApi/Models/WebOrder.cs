using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebOrder
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Currency { get; set; }
        public string Total { get; set; }
        public string TotalTax { get; set; }
        public WebCustomer Billing { get; set; }
        public WebCustomer Shipping { get; set; }
    }
}
