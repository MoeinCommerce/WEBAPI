using RestSharp;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Policy;
using WebApi.Contexts.Interfaces;
using WebApi.Models;

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

        public WebProduct GetProductById(string id)
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

        public IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<string> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public string CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public string UpdateProduct(string id, WebProduct entity, List<ExcludedFields> excludedFields = null)
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

        public string GetMaxProductId()
        {
            throw new System.NotImplementedException();
        }
        public string GetTotalProductsCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariationProductsByVariableId(string variableId)
        {
            throw new NotImplementedException();
        }
        public void UpdateVariationProduct(string variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        public string CreateVariableProduct(WebProduct variableProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        public string CreateVariationProduct(string variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Category

        public WebCategory GetCategoryById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<string> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public string CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public string UpdateCategory(string id, WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public string GetMaxCategoryId()
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }

        public string CreateCustomer(WebCustomer entity)
        {
            throw new System.NotImplementedException();
        }

        public string GetTotalCategoriesCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public WebCustomer GetCustomerById(string id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<string> idsToExclude, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<string> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebOrder> GetOrdersBySearch(
            IEnumerable<string> idsToExclude,
            string searchTerm,
            IEnumerable<OrderStatus> statuses,
            string customerId, 
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
        public IEnumerable<KeyValuePair<string, string>> GetCustomerIdAndNameBySearch(
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

        public void UpdateOrderStatus(string orderId, OrderStatus status)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}