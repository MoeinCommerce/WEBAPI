using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repositories.Entities;

namespace WebApi.Contexts
{
    public interface IWebContext
    {
        IProductRepository WebProductRepository { get; }
        IOrderRepository WebOrderRepository { get; }
        ICategoryRepository WebCategoryRepository { get; }
        void Dispose();
    }
}
