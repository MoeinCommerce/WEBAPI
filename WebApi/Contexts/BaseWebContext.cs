using System;
using System.Collections.Generic;
using System.Security.Policy;
using WebApi.Models;
using WebApi.Contexts.Interfaces;
using RestSharp;

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

        public int CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateProduct(int id, WebProduct entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetAllProductsWithFields(ProductTypes productType)
        {
            return new List<WebProduct>();
        }

        public IEnumerable<WebProduct> SearchProducts(string searchTerm, ProductTypes productType, int page = 1, int pageSize = 10, int maxPage = 1)
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

        public IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariationProductsByVariableId(int variableId)
        {
            throw new NotImplementedException();
        }
        public void UpdateVariationProduct(int variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
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

        public int CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateCategory(int id, WebCategory entity, List<ExcludedFields> excludedFields = null)
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

        public int CreateCustomer(WebCustomer entity)
        {
            throw new System.NotImplementedException();
        }

        public int GetTotalCategoriesCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public WebCustomer GetCustomerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<int> idsToExclude, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebOrder> GetOrdersBySearch(
            IEnumerable<int> idsToExclude,
            string searchTerm,
            IEnumerable<OrderStatus> statuses,
            int? customerId, 
            decimal totalMin, 
            decimal totalMax,
            DateTime startDate, 
            DateTime endDate, 
            int page = 1,
            int pageSize = 10, 
            int maxPage = 1)
        {
            throw new NotImplementedException();
        }

        #endregion
        
        #region Customer
        
        public IEnumerable<WebCustomer> SearchCustomers(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<KeyValuePair<int, string>> GetCustomerIdAndNameBySearch(
            string searchTerm,
            int page = 1,
            int pageSize = 10,
            int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region PaymentMethods

        public IEnumerable<WebPaymentMethod> GetAllPaymentMethods()
        {
            throw new NotImplementedException();
        }

        #endregion
        
        #region Other Methods

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool ValidateConnection()
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderStatus(int orderId, OrderStatus status)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}