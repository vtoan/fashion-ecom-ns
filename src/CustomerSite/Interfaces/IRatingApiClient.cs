using System.Collections.Generic;
using Shared.ViewModels;
using System.Threading.Tasks;


namespace CustomerSite.Interfaces
{
    public interface IRatingApiClient
    {
        Task<IEnumerable<RatingVM>> GetByProductAsync(int id);
        Task<RatingVM> CreateAsync(int productId, RatingVM ratingVM);
    }
}