﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Contexts.Interfaces
{
    public interface IWebContext
    {
        bool ValidateConnection();
        #region Product

        WebProduct GetProductById(int id);
        IEnumerable<WebProduct> GetAllProducts();
        IEnumerable<WebProduct> GetAllProductsExcludingIds(IList<int> idsToExclude);
        int CreateProduct(WebProduct entity, List<ExcludedFields> excludedFields = null);
        int UpdateProduct(int id, WebProduct entity, List<ExcludedFields> excludedFields = null);
        int GetTotalProductsCount(string searchTerm);
        IEnumerable<WebProduct> GetAllProductsWithFields(ProductTypes productType);
        IEnumerable<WebProduct> SearchProducts(string searchTerm, ProductTypes productType, int page = 1, int pageSize = 10, int maxPage = 1);
        int GetMaxProductId();
        int GetTotalCategoriesCount(string searchTerm);

        #endregion

        #region  VariableProduct
        IEnumerable<WebProduct> GetVariableProductsBySearch(string searchTerm);
        IEnumerable<WebProduct> GetVariationProductsByVariableId(int variableId);
        void UpdateVariationProduct(int variableId, WebProduct variationProduct, List<ExcludedFields> excludedFields = null);

        #endregion

        #region Category
        WebCategory GetCategoryById(int id);
        IEnumerable<WebCategory> GetAllCategories();
        IEnumerable<WebCategory> GetAllCategoriesExcludingIds(IList<int> idsToExclude);
        int CreateCategory(WebCategory entity, List<ExcludedFields> excludedFields = null);
        int UpdateCategory(int id, WebCategory entity, List<ExcludedFields> excludedFields = null);
        IList<WebCategory> GetAllCategoriesWithFields(IList<string> fields);
        int GetMaxCategoryId();
        IList<WebCategory> SearchCategories(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);

        #endregion

        #region Customers

        int CreateCustomer(WebCustomer entity);
        IEnumerable<WebCustomer> SearchCustomers(string searchTerm, int page = 1, int pageSize = 10, int maxPage = 1);
        IEnumerable<WebCustomer> GetAllCustomersWithFields(IList<string> fields);
        WebCustomer GetCustomerById(int id);

        IEnumerable<KeyValuePair<int, string>> GetCustomerIdAndNameBySearch(string searchTerm, int page = 1, int pageSize = 10,
            int maxPage = 1);
        

        #endregion
        
        # region Orders
        
        IEnumerable<WebOrder> GetAllOrdersExcludeById(IEnumerable<int> idsToExclude, DateTime? startDate, DateTime? endDate);
        IEnumerable<WebOrder> GetOrdersByFilters(DateTime? startDate, DateTime? endDate, IEnumerable<int> idsToExclude = null, IEnumerable<OrderStatus> orderStatuses = null);
        IEnumerable<WebOrder> GetOrdersBySearch(
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
            int maxPage = 1);
        void UpdateOrderStatus(int orderId, OrderStatus status);
        #endregion

        #region PaymentMethods

        IEnumerable<WebPaymentMethod> GetAllPaymentMethods();

        #endregion
        void Dispose();
    }
}
