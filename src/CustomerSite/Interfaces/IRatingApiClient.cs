using System.Collections.Generic;
using Shared.ViewModels;
using System.Threading.Tasks;


namespace CustomerSite.Interfaces
{
    public interface IRatingApiClient
    {
        Task<IEnumerable<RatingVM>> GetByProduct(int id);
        Task<RatingVM> Create(int productId, string userId, RatingVM ratingVM);
    }
}