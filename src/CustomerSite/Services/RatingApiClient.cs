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

        public async Task<RatingVM> CreateAsync(int productId, RatingVM ratingVM)
        {
            var router = routeName + "?productId=" + productId;
            return await _request.PostAsync<RatingVM>(router, ratingVM);
        }

        public async Task<IEnumerable<RatingVM>> GetByProductAsync(int id)
        {
            return await _request.GetAsync<IEnumerable<RatingVM>>(routeName + "/product/" + id);
        }
    }
}