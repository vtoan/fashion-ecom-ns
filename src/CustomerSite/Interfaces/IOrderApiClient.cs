using Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CustomerSite.Interfaces
{
    public interface IOrderApiClient
    {
        Task<OrderDetailVM> CreateAsync(OrderDetailVM orderDetailVM, List<OrderItemVM> listItem);
        Task<OrderDetailVM> GetAsync(int id);
        Task<IEnumerable<FeeVM>> GetListAsync();

    }
}