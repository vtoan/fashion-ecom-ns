using System;
using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces.DAOs
{
    public interface IOrderDAO :
       IGetItem<Order>,
       IAddItem<Order>
    {
        (ICollection<Order> Orders, int TotalItem) GetListItems(DateTime start, DateTime end, int provinceId, int limited, int offset);
        (ICollection<Order> Orders, int TotalItem) GetListItemsByPhone(string query, int provinceId, int limited, int offset);
        (ICollection<Order> Orders, int TotalItem) GetListItemsByUser(string userId, int provinceId, int limited, int offset);
    }
}