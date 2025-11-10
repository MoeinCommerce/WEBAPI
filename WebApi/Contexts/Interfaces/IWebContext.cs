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

        WebProduct GetProductById(long id);
        IEnumerable<WebProduct> GetAllProducts();
        IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<long> idsToExclude);
        long CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null);
        long UpdateProduct(long id, WebProduct entity, List<ExcludedFields> excludedFields = null);
        long GetTotalProductsCount(string searchTerm);
        IEnumerable<WebProduct> GetAllProductsWithFields(ProductTypes productType);
        IEnumerable<WebProduct> SearchProducts(string searchTerm, ProductTypes productType, int page = 1, int pageSize = 10, int maxPage = 1);
        long GetMaxProductId();
        long GetTotalCategoriesCount(string searchTerm);

        #endregion

        #region  VariableProduct
        long CreateVariableProduct(WebProduct variableProduct, List<ExcludedFields> excludedFields = null);
        long CreateVariationProduct(long variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);
        IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm);
        IEnumerable<WebProduct> GetVariationProductsByVariableId(long variableId);
        void UpdateVariationProduct(long variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);

        #endregion

        #region Category
        WebCategory GetCategoryById(long id);
        IEnumerable<WebCategory> GetAllCategories();
        IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<long> idsToExclude);
        long CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null);
        long UpdateCategory(long id, WebCategory entity, List<ExcludedFields> excludedFields = null);
        IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields);
        long GetMaxCategoryId();
        IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);

        #endregion

        #region Customers

        long CreateCustomer(WebCustomer entity);
        IEnumerable<WebCustomer> SearchCustomers(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);
        IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields);
        WebCustomer GetCustomerById(long id);

        IEnumerable<KeyValuePair<long, string>> GetCustomerIdAndNameBySearch(string searchTerm, int page = 1, int pageSize = 10,
            int maxPage = 1);
        

        #endregion
        
        # region Orders
        
        IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<long> idsToExclude, DateTime? startDate, DateTime? endDate);
        IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<long> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null);
        IEnumerable<WebOrder> GetOrdersBySearch(
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
            int maxPage = 1);
        void UpdateOrderStatus(long orderId, OrderStatus status);
        #endregion

        #region PaymentMethods

        IEnumerable<WebPaymentMethod> GetAllPaymentMethods();

        #endregion
        void Dispose();
    }
}
