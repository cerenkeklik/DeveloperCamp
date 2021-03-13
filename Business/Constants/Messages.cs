using System;
using System.Collections.Generic;
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
    }
}
