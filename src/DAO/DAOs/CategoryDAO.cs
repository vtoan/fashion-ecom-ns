using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Interfaces.DAOs;

namespace DAO.DAOs
{
    public class CategoryDAO :
        BaseDAO<Category>,
        ICategoryDAO
    {
        public CategoryDAO(AppDbContext context) : base(context)
        { }

        public ICollection<Category> GetListItems(int typeProductId)
        {
            return _context.Categories.Where(item => item.TypeProductId == typeProductId).ToList();
        }
    }
}