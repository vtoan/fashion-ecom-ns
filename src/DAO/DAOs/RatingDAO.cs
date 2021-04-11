using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using Microsoft.EntityFrameworkCore;

namespace DAO.DAOs
{
    public class RatingDAO :
        BaseDAO<Rating>,
        IRatingDAO
    {
        public RatingDAO(AppDbContext context) : base(context)
        { }

        public ICollection<Rating> GetByProduct(int productId)
        {
            return _context.Ratings.Where(item => item.ProductId == productId).Include(item => item.User).ToList();
        }

        public ICollection<Rating> GetByUser(string userId)
        {
            return _context.Ratings.Where(item => item.UserId == userId).ToList();
        }

    }
}