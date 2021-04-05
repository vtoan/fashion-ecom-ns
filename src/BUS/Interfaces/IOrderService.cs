using System;
using System.Collections.Generic;
using BUS.Domains;

namespace BUS.Interfaces
{
    public interface IOrderService :
        IGet<Order>,
        IAdd<Order>,
        IUpdate<Order>,
        IDelete<Order>
    {
        Tuple<ICollection<Order>, int> GetList(string query, DateTime start, DateTime end);
        bool UploadImage(int productId, string imgName);
    }
}