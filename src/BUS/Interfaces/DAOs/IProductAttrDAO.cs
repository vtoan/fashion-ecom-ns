using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces.DAOs
{
    public interface IProductAttrDAO :
        IBaseDAO<ProductAttr>
    {
        ICollection<ProductAttr> GetListItems(int productId);

        ICollection<ProductAttr> GetListCartItem(int[] productAttrIds);
    }
}