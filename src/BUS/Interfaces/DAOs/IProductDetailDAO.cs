using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces.DAOs
{
    public interface IProductDetailDAO :
        IBaseDAO<ProductDetail>
    {
        ICollection<ProductDetail> GetListItems(int productId);
    }
}