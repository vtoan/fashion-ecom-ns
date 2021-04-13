using System.Collections.Generic;
using BUS.Domains;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IProductDetailService :
        IGet<ProductAttributeVM>,
        //  IAdd<ProductDetailVM>,
        IUpdate<ProductAttributeVM>,
        IDelete<ProductAttributeVM>
    {
        ICollection<ProductAttributeVM> GetList(int productId);
        ProductAttributeVM Add(int productId, ProductAttributeVM newObject);

        ICollection<CartItemVM> GetListCartItem(int[] productAttrIds);


    }
}