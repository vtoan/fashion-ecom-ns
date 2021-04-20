using System.Collections.Generic;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IUserService
    {
        (ICollection<UserVM> Users, int TotalItem) GetList(string query, int limited, int offset);

    }
}