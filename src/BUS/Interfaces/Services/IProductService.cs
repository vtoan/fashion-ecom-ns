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
        (ICollection<ProductVM> Products, int Total) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
    }
}