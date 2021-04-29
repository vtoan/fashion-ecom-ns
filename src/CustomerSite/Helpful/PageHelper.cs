using System.Linq;
using System.Security.Claims;
using Shared.Enums;

namespace CustomerSite.Helpful
{
    public static class PageHelper
    {
        public static readonly string KEY_CART_SESSION = "cart";
        public static readonly string KEY_FEE_SESSION = "fee";

        public static string CreateURI(int typeId = 0, int cateId = 0, ProductSort? sort = null, int page = 0, string query = null)
        {
            var queryStr = "";
            if (query != null) queryStr += nameof(query) + "=" + query;
            if (cateId > 0) queryStr += (queryStr == "" ? "" : "&&") + nameof(cateId) + "=" + cateId;
            if (sort != null) queryStr += (queryStr == "" ? "" : "&&") + nameof(sort) + "=" + sort;
            if (page > 1) queryStr += (queryStr == "" ? "" : "&&") + nameof(page) + "=" + page;
            var result = "?" + queryStr;
            if (typeId != 0) result = "/type/" + typeId + result;
            return result;
        }

        public static double CalFee(double total, double cost)
        {
            if (cost % 1 == 0) return total + cost;
            return (total * cost);
        }

        public static string GetUserName(ClaimsPrincipal user)
        {
            var userName = user.Identities.First().Claims.FirstOrDefault(item => item.Type == "name").Value;
            var name = userName.Split("@")[0].ToUpper();
            return name;
        }
    }
}