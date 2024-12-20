﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class WebOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PaymentMethodId { get; set; }
        public string TransactionId { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string Currency { get; set; }
        public double ShippingTotal { get; set; }
        public double OrderTax { get; set; }
        public double OrderDiscount { get; set; }
        public double UnitPrice { get; set; }
        public WebCustomer Billing { get; set; }
        public WebCustomer Shipping { get; set; }
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
}
