using Shared.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CustomerSite.Interfaces
{
    public interface IOrderApiClient
    {
        Task<OrderDetailVM> Create(OrderDetailVM orderDetailVM, List<OrderItemVM> listItem);
        Task<OrderDetailVM> Get(int id);
        Task<IEnumerable<FeeVM>> GetList();

    }
}