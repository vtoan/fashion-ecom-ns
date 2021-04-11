using Shared.Enums;

namespace CustomerSite.Helpful
{
    public static class PageHelper
    {
        public static string createUrl(string query = null, int typeId = 0, int cateId = 0, ProductSort? sort = null, int page = 1)
        {
            var queryStr = "";
            if (query != null) queryStr += "query=" + query;
            if (typeId > 0) queryStr += (queryStr == "" ? "" : "&&") + "typeId=" + typeId;
            if (cateId > 0) queryStr += (queryStr == "" ? "" : "&&") + "cateId=" + cateId;
            if (sort != null) queryStr += (queryStr == "" ? "" : "&&") + "sort=" + sort;
            if (page > 1) queryStr += (queryStr == "" ? "" : "&&") + "page=" + page;
            return "?" + queryStr;
        }
    }
}