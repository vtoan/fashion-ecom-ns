using System;
using System.Collections.Generic;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IOrderService :
        IGet<OrderDetailVM>,
        IAdd<OrderDetailVM>
    {
        (ICollection<OrderVM> Orders, int TotalItem) GetList(string start, string end, int provinceId, int limited, int offset);
        (ICollection<OrderVM> Orders, int TotalItem) GetListByPhone(string query, int provinceId, int limited, int offset);
        (ICollection<OrderVM> Orders, int TotalItem) GetListByUser(string userId, int provinceId, int limited, int offset);
    }
}