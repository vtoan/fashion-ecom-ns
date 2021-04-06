using System.Collections.Generic;
using BUS.Domains;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IProductDetailService :
         IGet<ProductAttributeVM>,
         //  IAdd<ProductDetailVM>,
         //  IUpdate<ProductDetailVM>,
         IDelete<ProductAttributeVM>
    {
        ICollection<ProductAttributeVM> GetList(int productId, string size, string color);
        ProductAttributeVM Add(int productId, ProductAttributeVM newObject);
        bool Update(int productId, ProductAttributeVM modifiedObject);
    }
}