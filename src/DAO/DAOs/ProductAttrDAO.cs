using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using Microsoft.EntityFrameworkCore;

namespace DAO.DAOs
{
    public class ProductAttrDAO :
        BaseDAO<ProductAttr>,
        IProductAttrDAO
    {
        public ProductAttrDAO(AppDbContext context) : base(context)
        { }

        public ICollection<ProductAttr> GetListCartItem(int[] productAttrIds)
        {
            return _context.ProductAttrs
                        .Where(item => productAttrIds.Contains(item.Id))
                        .Include(item => item.Product)
                        .ToList();
        }

        public ICollection<ProductAttr> GetListItems(int productId)
        {
            return _context.ProductAttrs.Where(item => item.ProductId == productId).ToList();

        }

    }
}