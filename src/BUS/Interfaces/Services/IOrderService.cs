using System;
using System.Collections.Generic;
using BUS.Enums;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IOrderService :
        IGet<OrderDetailVM>,
        IAdd<OrderDetailVM>
    {
        (ICollection<OrderVM>, int) GetList(DateTime start, DateTime end, int provinceId, int limited, int offset);
        (ICollection<OrderVM>, int) GetListByPhone(string query, int provinceId, int limited, int offset);
        (ICollection<OrderVM>, int) GetListByUser(string userId, int provinceId, int limited, int offset);
        // bool UpdateStatus(int orderId, OrderStatus status);
    }
}