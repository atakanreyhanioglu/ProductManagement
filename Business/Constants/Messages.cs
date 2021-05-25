using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductGetAll = "All Products Listed!";

        public static string ProductGetById = "Product Listed!";

        public static string ProductAdded = "Product Added!";

        public static string ProductDeleted = "Product Deleted!";

        public static string ProductUpdated = "Product Updated!";

        public static string CategoryListed = "Product Listed By Category!";

        public static string CategoryAdded = "Category Added!";

        public static string CategoryUpdated = "Category Updated!";

        public static string CategoryDeleted = "Category Deleted!";

        public static string AllCategoriesListed = "All Categories Listed!";

        public static string SupplierAdded = "Supplier Added!";

        public static string SupplierDeleted = "Supplier Deleted!";

        public static string SupplierUpdated = "Supplier Updated!";

        public static string AllSuppliersListed = "All Suppliers Listed!";

        public static string AllSuppliersListedByCityName = "All Suppliers Listed By City Name!";

        public static string AllSuppliersListedByCountryName = "All Suppliers Listed By Country Name!";

        public static string CustomerAdded = "Customer Added!";

        public static string CustomerUpdated = "Customer Updated!";

        public static string CustomerDeleted = "Customer Deleted!";

        public static string AllCustomersListedByCountryName = "All Customers Listed By Country Name!";

        public static string AllCustomersListedByCityName = "All Customers Listed By City Name!";

        public static string AllCustomersListed = "All Customers Listed!";

        public static string GetAllProductsBySupplierId = "All Products Listed By Supplier ";

        public static string GetAllProductsByCategoryId = "All Products Listed By Category ";

        public static string AuthorizationDenied = "Authorization Denied!";

        public static string UserAlreadyExists = "User Already Exist!";
        public static string AccessTokenCreated = "Access Token Created!";
        public static string SuccessfulLogin = "Successful Login!";
        public static string PasswordError = "Password Error!";
        public static string UserNotFound = "User Not Found!";
        public static string UserRegistered = "User Registered!";
        public static string UserAdded = "User Added!";
        public static string UserGetAll = "All Users Listed!";
    }
}
