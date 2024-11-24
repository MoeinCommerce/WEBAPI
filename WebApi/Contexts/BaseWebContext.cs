using System.Collections.Generic;
using System.Security.Policy;
using WebApi.Models;
using WebApi.Contexts.Interfaces;

namespace WebApi.Contexts
{
    public class BaseWebContext : IWebContext
    {
        # region Fields

        protected readonly string Url;
        protected readonly Dictionary<string, string> Configs;

        #endregion

        #region Constructors

        protected BaseWebContext(string url, Dictionary<string, string> configs)
        {
            Url = url;
            Configs = configs;
        }

        #endregion

        #region Product

        public WebProduct GetProductById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }
        
        public IEnumerable<WebProduct> SearchProducts(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<int> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public int CreateProduct(WebProduct entity)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateProduct(int id, WebProduct entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetAllProductsWithFields(IList<string> fields)
        {
            return new List<WebProduct>();
        }

        public IEnumerable<WebProduct> SearchProducts(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            return new List<WebProduct>();
        }

        public int GetMaxProductId()
        {
            throw new System.NotImplementedException();
        }
        public int GetTotalProductsCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region Category

        public WebCategory GetCategoryById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<int> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public int CreateCategory(WebCategory entity)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateCategory(int id, WebCategory entity)
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public int GetMaxCategoryId()
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalCategoriesCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        
        #region Customer
        
        public IEnumerable<WebCustomer> SearchCustomers(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }
        
        #endregion

        #region Other Methods

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}