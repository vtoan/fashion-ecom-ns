using Shared.Enums;

namespace CustomerSite.Helpful
{
    public static class PageHelper
    {
        public static readonly string KEY_CART_SESSION = "cart";
        public static readonly string KEY_FEE_SESSION = "fee";

        public static string CreateURI(int cateId = 0, ProductSort? sort = null, int page = 0, string query = null)
        {
            var queryStr = "";
            if (query != null) queryStr += nameof(query) + "=" + query;
            if (cateId > 0) queryStr += (queryStr == "" ? "" : "&&") + nameof(cateId) + "=" + cateId;
            if (sort != null) queryStr += (queryStr == "" ? "" : "&&") + nameof(sort) + "=" + sort;
            if (page > 1) queryStr += (queryStr == "" ? "" : "&&") + nameof(page) + "=" + page;
            return "?" + queryStr;
        }

        public static double CalFee(double total, double cost)
        {
            if (cost % 1 == 0) return total + cost;
            return (total * cost);
        }
    }
}