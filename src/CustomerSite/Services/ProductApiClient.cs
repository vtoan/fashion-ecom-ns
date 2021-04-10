using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSite.Interfaces;
using Shared.Enums;
using Shared.ViewModels;

namespace CustomerSite.Services
{
    public class ProductApiClient : IProductApiClient
    {
        private readonly IRequestAPI _request;

        private readonly string routeName = "product";
        public ProductApiClient(IRequestAPI request)
        {
            _request = request;
        }
        public async Task<ProductDetailVM> Get(int id)
        {
            return await _request.GetAsync<ProductDetailVM>(routeName + "/" + id);
        }

        public async Task<IEnumerable<ProductAttributeVM>> GetAttributes(int productId)
        {
            return await _request.GetAsync<IEnumerable<ProductAttributeVM>>(routeName + "/" + productId + "attrs");
        }

        public async Task<IEnumerable<ProductVM>> GetList(string query = null, int typeId = 0, int cateId = 0, int limited = 0, int offset = 0, ProductSort? sort = null)
        {
            var queryStr = "";
            if (query != null) queryStr += "query=" + query;
            if (typeId > 0) queryStr += "typeId=" + typeId;
            if (cateId > 0) queryStr += "cateId=" + cateId;
            if (limited > 0) queryStr += "limited=" + limited;
            if (offset > 0) queryStr += "offset=" + offset;
            if (sort != null) queryStr += "sort=" + sort.ToString();
            var par = (query == "" ? "" : "?" + queryStr);
            return await _request.GetAsync<IEnumerable<ProductVM>>(routeName, par);
        }

        public async Task<IEnumerable<string>> GetListImage(int id)
        {
            return await _request.GetAsync<IEnumerable<string>>(routeName + "/" + id + "/images");
        }
    }
}