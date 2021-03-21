using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //publicler variable olsa dahi pascal case yazılır
        public static string ProductAdded = "Product Added";
        public static string ProductNameInvalid = "Product name invalid.";
        public static string MaintenanceTime = "System in maintenance time.";
        public static string ProductsListed = "Products listed.";
        public static string ProductCountOfCategoryError = "In a category, product number can be at most 10";
        public static string ProductNameAlreadyExists = "Product name must be unique";
        public static string CategoryLimitExceeded = "Category limit exceeded.";
        public static string AuthorizationDenied = "Authorization denied.";
        public static string UserRegistered = "User registered.";
        public static string UserNotFound = "User not found.";
        public static string PasswordError = "Pasword error.";
        public static string SuccessfulLogin = "Successful login.";
        public static string UserAlreadyExists = "User already exists.";
        public static string AccessTokenCreated = "Access token created.";
    }
}
