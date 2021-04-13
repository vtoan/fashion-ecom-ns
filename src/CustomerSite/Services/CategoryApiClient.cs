using System.Collections.Generic;
using CustomerSite.Interfaces;
using Shared.ViewModels;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public class CategoryApiClient : ICategoryApiClient
    {
        private readonly IRequestAPI _request;

        private readonly string routeName = "category";
        public CategoryApiClient(IRequestAPI request)
        {
            _request = request;
        }
        public async Task<IEnumerable<CategoryVM>> GetListAsync(int typeId)
        {
            return await _request.GetAsync<IEnumerable<CategoryVM>>(routeName + "?typeId=" + typeId);
        }
    }
}