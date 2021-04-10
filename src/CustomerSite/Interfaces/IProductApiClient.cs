using System.Collections.Generic;
using Shared.Enums;
using Shared.ViewModels;
using System.Threading.Tasks;

namespace CustomerSite.Interfaces
{
    public interface IProductApiClient
    {
        Task<IEnumerable<ProductVM>> GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
        Task<IEnumerable<string>> GetListImage(int id);
        Task<ProductDetailVM> Get(int id);
        Task<IEnumerable<ProductAttributeVM>> GetAttributes(int productId);
    }
}