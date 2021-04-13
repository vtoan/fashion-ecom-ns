using System.Collections.Generic;
using BUS.Domains;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IProductAttrService :
        IGet<ProductAttributeVM>,
        IUpdate<ProductAttributeVM>,
        IDelete<ProductAttributeVM>
    {
        ICollection<ProductAttributeVM> GetList(int productId);
        ProductAttributeVM Add(int productId, ProductAttributeVM newObject);
        ICollection<OrderItemVM> GetListCartItem(int[] productAttrIds);


    }
}