using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Contexts.Interfaces
{
    public interface IWebContext
    {
        #region Product

        WebProduct GetProductById(int id);
        IEnumerable<WebProduct> GetAllProducts();
        IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<int> idsToExclude);
        int CreateProduct(WebProduct entity);
        int UpdateProduct(int id, WebProduct entity);
        int GetTotalProductsCount(string searchTerm);
        IEnumerable<WebProduct> GetAllProductsWithFields(IList<string> fields);
        IEnumerable<WebProduct> SearchProducts(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);
        int GetMaxProductId();
        int GetTotalCategoriesCount(string searchTerm);

        #endregion

        #region Category
        WebCategory GetCategoryById(int id);
        IEnumerable<WebCategory> GetAllCategories();
        IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<int> idsToExclude);
        int CreateCategory(WebCategory entity);
        int UpdateCategory(int id, WebCategory entity);
        IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields);
        int GetMaxCategoryId();
        IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);

        #endregion

        void Dispose();
    }
}
