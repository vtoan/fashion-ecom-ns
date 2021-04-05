using System.Collections.Generic;
using BUS.Domains;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IProductDetailService :
         IGet<ProductDetailVM>,
         IAdd<ProductDetailVM>,
         IUpdate<ProductDetailVM>,
         IDelete<ProductDetailVM>
    {
        ICollection<ProductDetailVM> GetList(int productId, string size, string color);
    }
}