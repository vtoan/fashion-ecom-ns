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

        public async Task<ProductDetailVM> GetAsync(int id)
        {
            return await _request.GetAsync<ProductDetailVM>(routeName + "/" + id);
        }

        public async Task<IEnumerable<ProductAttributeVM>> GetAttributesAsync(int productId)
        {
            return await _request.GetAsync<IEnumerable<ProductAttributeVM>>(routeName + "/" + productId + "attrs");
        }

        public async Task<(IEnumerable<ProductVM> Products, int TotalItem)> GetListAsync(string query = null, int typeId = 0, int cateId = 0, int limited = 0, int offset = 0, ProductSort? sort = null)
        {
            var queryParam = _createQueryRequest(query, typeId, cateId, limited, offset, sort);
            var resp = await _request.GetWithRespAsync<IEnumerable<ProductVM>>(routeName, queryParam);
            var totalItem = 0;
            if (resp.Header.Contains("total-item")) totalItem = Int32.Parse(resp.Item2.GetValues("total-item").First());
            return (resp.Data, totalItem);
        }

        public async Task<IEnumerable<string>> GetListImageAsync(int id)
        {
            return await _request.GetAsync<IEnumerable<string>>(routeName + "/" + id + "/images");
        }

        public async Task<IEnumerable<OrderItemVM>> GetListCartItemsAsync(string productAttrIds)
        {
            return await _request.GetAsync<IEnumerable<OrderItemVM>>(routeName + "/attrs?attrIds=" + productAttrIds);
        }


        private string _createQueryRequest(string query = null, int typeId = 0, int cateId = 0, int limited = 0, int offset = 0, ProductSort? sort = null)
        {
            var queryStr = "";
            if (query != null) queryStr += nameof(query) + "=" + query;
            if (typeId > 0) queryStr += (queryStr == "" ? "" : "&&") + nameof(typeId) + "=" + typeId;
            if (cateId > 0) queryStr += (queryStr == "" ? "" : "&&") + nameof(cateId) + "=" + cateId;
            if (limited > 0) queryStr += (queryStr == "" ? "" : "&&") + nameof(limited) + "=" + limited;
            if (offset > 0) queryStr += (queryStr == "" ? "" : "&&") + nameof(offset) + "=" + offset;
            if (sort != null) queryStr += (queryStr == "" ? "" : "&&") + nameof(sort) + "=" + sort;
            return (query == "" ? "" : "?" + queryStr);
        }
    }
}