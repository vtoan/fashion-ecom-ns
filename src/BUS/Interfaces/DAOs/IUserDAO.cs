using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces.DAOs
{
    public interface IUserDAO : IBaseDAO<User>
    {
        (ICollection<User> Users, int TotalItem) GetListItems(string query, int limited, int offset);
    }
}