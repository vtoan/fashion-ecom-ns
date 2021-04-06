using System;
using System.Collections.Generic;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
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