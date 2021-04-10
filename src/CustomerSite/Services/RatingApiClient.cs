using System.Collections.Generic;
using CustomerSite.Interfaces;
using Shared.ViewModels;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public class RatingApiClient : IRatingApiClient
    {
        private readonly IRequestAPI _request;

        private readonly string routeName = "rating";
        public RatingApiClient(IRequestAPI request)
        {
            _request = request;
        }

        public async Task<RatingVM> Create(int productId, string userId, RatingVM ratingVM)
        {
            var router = routeName + "?productId=" + productId + "&&userId" + userId;
            return await _request.PostAsync<RatingVM>(router, ratingVM);
        }

        public async Task<IEnumerable<RatingVM>> GetByProduct(int id)
        {
            return await _request.GetAsync<IEnumerable<RatingVM>>(routeName + "/" + id);
        }
    }
}