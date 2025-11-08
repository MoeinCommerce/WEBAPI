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

        WebProduct GetProductById(BigInteger id);
        IEnumerable<WebProduct> GetAllProducts();
        IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<BigInteger> idsToExclude);
        BigInteger CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null);
        BigInteger UpdateProduct(BigInteger id, WebProduct entity, List<ExcludedFields> excludedFields = null);
        BigInteger GetTotalProductsCount(string searchTerm);
        IEnumerable<WebProduct> GetAllProductsWithFields(ProductTypes productType);
        IEnumerable<WebProduct> SearchProducts(string searchTerm, ProductTypes productType, int page = 1, int pageSize = 10, int maxPage = 1);
        BigInteger GetMaxProductId();
        BigInteger GetTotalCategoriesCount(string searchTerm);

        #endregion

        #region  VariableProduct
        BigInteger CreateVariableProduct(WebProduct variableProduct, List<ExcludedFields> excludedFields = null);
        BigInteger CreateVariationProduct(BigInteger variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);
        IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm);
        IEnumerable<WebProduct> GetVariationProductsByVariableId(BigInteger variableId);
        void UpdateVariationProduct(BigInteger variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);

        #endregion

        #region Category
        WebCategory GetCategoryById(BigInteger id);
        IEnumerable<WebCategory> GetAllCategories();
        IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<BigInteger> idsToExclude);
        BigInteger CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null);
        BigInteger UpdateCategory(BigInteger id, WebCategory entity, List<ExcludedFields> excludedFields = null);
        IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields);
        BigInteger GetMaxCategoryId();
        IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);

        #endregion

        #region Customers

        BigInteger CreateCustomer(WebCustomer entity);
        IEnumerable<WebCustomer> SearchCustomers(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);
        IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields);
        WebCustomer GetCustomerById(BigInteger id);

        IEnumerable<KeyValuePair<BigInteger, string>> GetCustomerIdAndNameBySearch(string searchTerm, int page = 1, int pageSize = 10,
            int maxPage = 1);
        

        #endregion
        
        # region Orders
        
        IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<BigInteger> idsToExclude, DateTime? startDate, DateTime? endDate);
        IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<BigInteger> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null);
        IEnumerable<WebOrder> GetOrdersBySearch(
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
            int maxPage = 1);
        void UpdateOrderStatus(BigInteger orderId, OrderStatus status);
        #endregion

        #region PaymentMethods

        IEnumerable<WebPaymentMethod> GetAllPaymentMethods();

        #endregion
        void Dispose();
    }
}
