using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces.DAOs
{
    public interface ICategoryDAO :
        IBaseDAO<Category>
    {
        ICollection<Category> GetListItems(int typeProductId);
    }
}