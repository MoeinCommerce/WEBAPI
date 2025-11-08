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

        public WebProduct GetProductById(BigInteger id)
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

        public IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<BigInteger> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger UpdateProduct(BigInteger id, WebProduct entity, List<ExcludedFields> excludedFields = null)
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

        public BigInteger GetMaxProductId()
        {
            throw new System.NotImplementedException();
        }
        public BigInteger GetTotalProductsCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebProduct> GetVariationProductsByVariableId(BigInteger variableId)
        {
            throw new NotImplementedException();
        }
        public void UpdateVariationProduct(BigInteger variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        public BigInteger CreateVariableProduct(WebProduct variableProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        public BigInteger CreateVariationProduct(BigInteger variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Category

        public WebCategory GetCategoryById(BigInteger id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<BigInteger> idsToExclude)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger UpdateCategory(BigInteger id, WebCategory entity, List<ExcludedFields> excludedFields = null)
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger GetMaxCategoryId()
        {
            throw new System.NotImplementedException();
        }

        public IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger CreateCustomer(WebCustomer entity)
        {
            throw new System.NotImplementedException();
        }

        public BigInteger GetTotalCategoriesCount(string searchTerm)
        {
            throw new System.NotImplementedException();
        }
        public IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields)
        {
            throw new System.NotImplementedException();
        }

        public WebCustomer GetCustomerById(BigInteger id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<BigInteger> idsToExclude, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<BigInteger> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WebOrder> GetOrdersBySearch(
            IEnumerable<BigInteger> idsToExclude,
            string searchTerm,
            IEnumerable<OrderStatus> statuses,
            BigInteger? customerId, 
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
        public IEnumerable<KeyValuePair<BigInteger, string>> GetCustomerIdAndNameBySearch(
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

        public void UpdateOrderStatus(BigInteger orderId, OrderStatus status)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}