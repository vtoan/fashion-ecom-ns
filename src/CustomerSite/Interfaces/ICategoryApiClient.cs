using System.Collections.Generic;
using System.Threading.Tasks;
using Shared.ViewModels;

namespace CustomerSite.Interfaces
{
    public interface ICategoryApiClient
    {
        Task<IEnumerable<CategoryVM>> GetListAsync(int typeId);
    }
}