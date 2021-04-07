using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces.DAOs
{
    public interface IRatingDAO :
        IBaseDAO<Rating>
    {
        ICollection<Rating> GetByProduct(int productId);
        ICollection<Rating> GetByUser(string userId);
    }
}