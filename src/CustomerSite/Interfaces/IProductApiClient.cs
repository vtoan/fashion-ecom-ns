using System.Collections.Generic;
using Shared.Enums;
using Shared.ViewModels;
using System.Threading.Tasks;

namespace CustomerSite.Interfaces
{
    public interface IProductApiClient
    {
        Task<(IEnumerable<ProductVM> Products, int TotalItem)> GetListAsync(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
        Task<IEnumerable<string>> GetListImageAsync(int id);
        Task<ProductDetailVM> GetAsync(int id);
        Task<IEnumerable<ProductAttributeVM>> GetAttributesAsync(int productId);
        Task<IEnumerable<CartItemVM>> GetListCartItemsAsync(string productAttrIds);


    }
}