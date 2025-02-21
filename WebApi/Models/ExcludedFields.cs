using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public enum ExcludedFields
    {
        ProductName,
        // Ignored Product Items
        ProductPrice,      // Excludes the product price,
        ProductDiscount,   // Excludes the product discount
        Sku,               // Excludes the SKU (stock-keeping unit)
        Stock,             // Excludes the stock information
        CategoryOfProduct, // Excludes the product's category

        // Items for Categories
        CategoryName       // Excludes the category name
    }
    public enum ProductTypes
    {
        Simple,
        Variable,
        Variation
    }
}
