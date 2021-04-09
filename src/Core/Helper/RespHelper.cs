using Microsoft.AspNetCore.Http;

namespace Core.Helper
{
    public static class RespHelper
    {
        public static void AddTotalPage(HttpContext context, int totalItem)
        {
            context.Response.Headers.Add("total-item", totalItem.ToString());
        }
    }
}