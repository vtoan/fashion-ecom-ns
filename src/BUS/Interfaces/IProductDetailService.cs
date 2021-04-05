using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces
{
    public interface IProductDetailService :
         IGet<ProductDetail>,
         IAdd<ProductDetail>,
         IUpdate<ProductDetail>,
         IDelete<ProductDetail>
    {
        ICollection<ProductDetail> GetList(int productId, string size, string color);
    }
}