using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ProductImportBase
    {
        public virtual string Id { get; }
        public virtual string Name { get; }
        public virtual string CreatedDate { get; }
        public virtual string RegularPrice { get; }
        public virtual string SalePrice { get; }
        public virtual string Stock { get; }
        public virtual string Category { get; }
    }
}
