using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebOrder
    {
        private static string _baseUrl = "https://default.url"; // Default placeholder

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerNote { get; set; }
        public WebPaymentMethod PaymentMethod { get; set; }

        // Main app should set this base URL at runtime
        public static string BaseUrl
        {
            get => _baseUrl;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _baseUrl = value.TrimEnd('/'); // Ensure no trailing slash for consistency
                }
            }
        }
        // Developers set only the relative order path, e.g., "orders/123"
        public string OrderPath { get; set; }

        // Computed property combining base URL and order path
        public string Link => $"{BaseUrl}/{OrderPath}";

        public string TransactionId { get; set; }
        public OrderStatus Status { get; set; }
        public string StatusText { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Currency { get; set; }
        public double ShippingTotal { get; set; }
        public double OrderTax { get; set; }
        public double OrderDiscount { get; set; }
        public double UnitPrice { get; set; }
        public WebCustomer Billing { get; set; }
        public WebCustomer Shipping { get; set; }
        public WebShippingDetail ShippingDetail { get; set; }
        public List<WebOrderDetail> OrderItems { get; set; }
        // Computational Properties
        public double SubTotal 
        { 
            get
            {
                double subTotal = 0;
                foreach (var orderItem in OrderItems)
                {
                    subTotal += orderItem.SubTotal;
                }

                return subTotal;
            } 
        }

        public double ItemsDiscount
        { 
            get
            {
                double itemsDiscount = 0;
                foreach (var orderItem in OrderItems)
                {
                    itemsDiscount += orderItem.Discount;
                }

                return itemsDiscount;
            }
        }

        public double Discount => ItemsDiscount + OrderDiscount;

        public double Tax
        {
            get
            {
                double tax = OrderTax;
                foreach (var orderItem in OrderItems)
                {
                    tax += orderItem.Tax;
                }

                return tax;
            }
        }

        public double Total => SubTotal - Discount + Tax + ShippingTotal;
    }
    public enum OrderStatus
    {
        Pending = 0,
        OnHold = 1,
        Failed = 2,
        Processing = 3,
        Cancelled = 4,
        Completed = 5,
        Refunded = 6,
        Other = 7
    }
}
