using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Interfaces.DAOs;

namespace DAO.DAOs
{
    public class ProductDetailDAO :
        BaseDAO<ProductDetail>,
        IProductDetailDAO
    {
        public ProductDetailDAO(AppDbContext context) : base(context)
        { }

        public ICollection<ProductDetail> GetListItems(int productId)
        {
            return _context.ProductDetails.Where(item => item.ProductId == productId).ToList();

        }

    }
}