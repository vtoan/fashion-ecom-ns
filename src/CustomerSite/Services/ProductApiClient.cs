using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<(IEnumerable<ProductVM>, int)> GetList(string query = null, int typeId = 0, int cateId = 0, int limited = 0, int offset = 0, ProductSort? sort = null)
        {
            var queryStr = "";
            if (query != null) queryStr += "query=" + query;
            if (typeId > 0) queryStr += (query == "" ? "" : "&&") + "typeId=" + typeId;
            if (cateId > 0) queryStr += (query == "" ? "" : "&&") + "cateId=" + cateId;
            if (limited > 0) queryStr += (query == "" ? "" : "&&") + "limited=" + limited;
            if (offset > 0) queryStr += (query == "" ? "" : "&&") + "offset=" + offset;
            if (sort != null) queryStr += (query == "" ? "" : "&&") + "sort=" + sort;
            var par = (query == "" ? "" : "?" + queryStr);
            var resp = await _request.GetWithRespAsync<IEnumerable<ProductVM>>(routeName, par);
            var totalItem = 0;
            if (resp.Item2.Contains("total-item")) totalItem = Int32.Parse(resp.Item2.GetValues("total-item").First());
            return (resp.Item1, totalItem);
        }

        public async Task<IEnumerable<string>> GetListImage(int id)
        {
            return await _request.GetAsync<IEnumerable<string>>(routeName + "/" + id + "/images");
        }
    }
}