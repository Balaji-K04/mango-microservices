namespace Mango.Web.Utility
{
    public class StaticDetails
    {
        #region Base API
        public static string CouponAPIBase { get; set; } = string.Empty;
        public static string ProductAPIBase { get; set; } = string.Empty;
        public static string AuthAPIBase { get; set; } = string.Empty;
        public static string ShoppingCartAPIBase { get; set; } = string.Empty;
        public static string OrderAPIBase { get; set; } = string.Empty;
        #endregion Base API

        #region Role
        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";
        #endregion Role

        #region Status
        public const string Status_Pending = "Pending";
        public const string Status_Approved = "Approved";
        public const string Status_ReadyForPickup = "ReadyForPickup";
        public const string Status_Completed = "Completed";
        public const string Status_Refunded = "Refunded";
        public const string Status_Cancelled = "Cancelled";
        #endregion Status

        #region Enum
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
        #endregion Enum
    }
}
