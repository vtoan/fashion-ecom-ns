using System.Collections.Generic;
using CustomerSite.Interfaces;
using Shared.ViewModels;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public class OrderApiClient : IOrderApiClient
    {
        private readonly IRequestAPI _request;

        private readonly string routeName = "order";
        private readonly string routeFee = "fee";
        public OrderApiClient(IRequestAPI request)
        {
            _request = request;
        }

        public async Task<OrderDetailVM> CreateAsync(OrderDetailVM orderDetailVM, List<OrderItemVM> listItem)
        {
            return await _request.PostAsync<OrderDetailVM>(routeName, orderDetailVM);
        }

        public async Task<OrderDetailVM> GetAsync(int id)
        {
            return await _request.GetAsync<OrderDetailVM>(routeName + "/" + id);
        }

        public async Task<IEnumerable<FeeVM>> GetListAsync()
        {
            return await _request.GetAsync<IEnumerable<FeeVM>>(routeFee);
        }
    }
}