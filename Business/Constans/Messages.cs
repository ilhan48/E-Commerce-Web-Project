using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "The product is added!";
        public static string ProductNameInvalid = "The product's name is invalid!";
        public static string MaintenanceTime = "Service is maintenance!";
        public static string ProductsListed = "Products are listed!";
        public static string ProductCountOfCategoryError = "This category has more than 15 products. So process is not accept!";
        public static string ProductsNameIsSame = "The name of the product to be added already exists in the system!";
        public static string CategoryLimitExceded = "Categorys limites' full because products are not added!";
        public static string AuthorizationDenied = "You are not authorized!";
        public static string UserRegistered = "User is registered!";
        public static string UserNotFound = "User not found!";
        public static string PasswordError = " Password is not correct!";
        public static string SuccessfulLogin = "Login is successful!";
        public static string UserAlreadyExists = "User is already exists in system!";
        public static string AccessTokenCreated = "Access token created!";
    }
}
