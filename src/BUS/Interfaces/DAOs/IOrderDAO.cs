using System;
using System.Collections.Generic;
using BUS.Domains;
using BUS.Enums;

namespace BUS.Interfaces.DAOs
{
    public interface IOrderDAO :
       IGetItem<Order>,
       IAddItem<Order>
    {
        (ICollection<Order>, int) GetList(DateTime start, DateTime end, int provinceId, int limited, int offset);
        (ICollection<Order>, int) GetListByPhone(string query, int provinceId, int limited, int offset);
        (ICollection<Order>, int) GetListByUser(string userId, int provinceId, int limited, int offset);
        // bool UpdateStatus(int orderId, OrderStatus status);
    }
}