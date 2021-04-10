using System.Collections.Generic;
using Shared.Enums;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IProductService :
        IGet<ProductDetailVM>,
        IAdd<ProductDetailVM>,
        IUpdate<ProductDetailVM>,
        IDelete<ProductDetailVM>
    {
        // Tuple <Products, Numbers>
        (ICollection<ProductVM>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
        bool SetImageDefault(int productId, string imgName);
        bool RemoveImageDefault(int productId, string imgName);
        // ICollection<string> GetImages(int productId);
    }
}