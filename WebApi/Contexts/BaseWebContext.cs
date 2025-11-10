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

        public WebProduct GetProductById(long id)
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

        public IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<long> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public long CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public long UpdateProduct(long id, WebProduct entity, List<ExcludedFields> excludedFields = null)
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

        public long GetMaxProductId()
        {
            throw new System.NotImplementedException();
        }
        public long GetTotalProductsCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariationProductsByVariableId(long variableId)
        {
            throw new NotImplementedException();
        }
        public void UpdateVariationProduct(long variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        public long CreateVariableProduct(WebProduct variableProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        public long CreateVariationProduct(long variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Category

        public WebCategory GetCategoryById(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<long> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public long CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public long UpdateCategory(long id, WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public long GetMaxCategoryId()
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }

        public long CreateCustomer(WebCustomer entity)
        {
            throw new System.NotImplementedException();
        }

        public long GetTotalCategoriesCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public WebCustomer GetCustomerById(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<long> idsToExclude, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<long> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebOrder> GetOrdersBySearch(
            IEnumerable<long> idsToExclude,
            string searchTerm,
            IEnumerable<OrderStatus> statuses,
            long? customerId, 
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
        public IEnumerable<KeyValuePair<long, string>> GetCustomerIdAndNameBySearch(
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

        public void UpdateOrderStatus(long orderId, OrderStatus status)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}