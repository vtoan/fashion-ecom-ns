using System;
using System.Collections.Generic;
using BUS.Domains;
using Shared.ViewModels;

namespace BUS.Interfaces
{
    public interface IOrderService :
        IGet<OrderVM>,
        IAdd<OrderVM>,
        IUpdate<OrderVM>,
        IDelete<OrderVM>
    {
        Tuple<ICollection<OrderVM>, int> GetList(string query, DateTime start, DateTime end);

    }
}