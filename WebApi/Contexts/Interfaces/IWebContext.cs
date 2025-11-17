using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Contexts.Interfaces
{
    public interface IWebContext
    {
        bool ValidateConnection();
        #region Product

        WebProduct GetProductById(string id);
        IEnumerable<WebProduct> GetAllProducts();
        IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<string> idsToExclude);
        string CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null);
        string UpdateProduct(string id, WebProduct entity, List<ExcludedFields> excludedFields = null);
        string GetTotalProductsCount(string searchTerm);
        IEnumerable<WebProduct> GetAllProductsWithFields(ProductTypes productType);
        IEnumerable<WebProduct> SearchProducts(string searchTerm, ProductTypes productType, int page = 1, int pageSize = 10, int maxPage = 1);
        string GetMaxProductId();
        string GetTotalCategoriesCount(string searchTerm);

        #endregion

        #region  VariableProduct
        string CreateVariableProduct(WebProduct variableProduct, List<ExcludedFields> excludedFields = null);
        string CreateVariationProduct(string variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);
        IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm);
        IEnumerable<WebProduct> GetVariationProductsByVariableId(string variableId);
        void UpdateVariationProduct(string variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);

        #endregion

        #region Category
        WebCategory GetCategoryById(string id);
        IEnumerable<WebCategory> GetAllCategories();
        IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<string> idsToExclude);
        string CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null);
        string UpdateCategory(string id, WebCategory entity, List<ExcludedFields> excludedFields = null);
        IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields);
        string GetMaxCategoryId();
        IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);

        #endregion

        #region Customers

        string CreateCustomer(WebCustomer entity);
        IEnumerable<WebCustomer> SearchCustomers(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);
        IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields);
        WebCustomer GetCustomerById(string id);

        IEnumerable<KeyValuePair<string, string>> GetCustomerIdAndNameBySearch(string searchTerm, int page = 1, int pageSize = 10,
            int maxPage = 1);
        

        #endregion
        
        # region Orders
        
        IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<string> idsToExclude, DateTime? startDate, DateTime? endDate);
        IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<string> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null);
        IEnumerable<WebOrder> GetOrdersBySearch(
            IEnumerable<string> idsToExclude,
            string searchTerm,
            IEnumerable<OrderStatus> statuses,
            string? customerId,
            decimal totalMin,
            decimal totalMax,
            DateTime startDate,
            DateTime endDate,
            int page = 1,
            int pageSize = 10,
            int maxPage = 1);
        void UpdateOrderStatus(string orderId, OrderStatus status);
        #endregion

        #region PaymentMethods

        IEnumerable<WebPaymentMethod> GetAllPaymentMethods();

        #endregion
        void Dispose();
    }
}
