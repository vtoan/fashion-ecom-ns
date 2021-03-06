using System;
using System.Collections.Generic;
using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class OrderService :
        BaseService<OrderDetailVM, Order>,
        IOrderService
    {

        private readonly IOrderDAO _daoOrder;
        public OrderService(IOrderDAO dao, IMapper mapper) : base(null, mapper)
        {
            _daoOrder = dao;
        }

        public (ICollection<OrderVM> Orders, int TotalItem) GetList(string start, string end, int provinceId, int limited, int offset)
        {
            DateTime dateStart;
            DateTime dateEnd;
            DateTime.TryParse(start, out dateStart);
            DateTime.TryParse(end, out dateEnd);
            var result = _daoOrder.GetListItems(dateStart, dateEnd, provinceId, limited, offset);
            return (this._mapList<OrderVM, Order>(result.Orders), result.TotalItem);
        }

        public (ICollection<OrderVM> Orders, int TotalItem) GetListByPhone(string query, int provinceId, int limited, int offset)
        {
            var result = _daoOrder.GetListItemsByPhone(query, provinceId, limited, offset);
            return (this._mapList<OrderVM, Order>(result.Orders), result.TotalItem);
        }

        public (ICollection<OrderVM> Orders, int TotalItem) GetListByUser(string userId, int provinceId, int limited, int offset)
        {
            var result = _daoOrder.GetListItemsByUser(userId, provinceId, limited, offset);
            return (this._mapList<OrderVM, Order>(result.Orders), result.TotalItem);
        }

        public new OrderDetailVM Get(int id)
        {
            if (id <= 0) return null;
            var result = _daoOrder.GetItem(id);
            if (result == null) return null;
            return this._mapper.Map<OrderDetailVM>(result);
        }

        public new OrderDetailVM Add(OrderDetailVM newObject)
        {
            var obj = this._mapper.Map<Order>(newObject);
            var result = _daoOrder.AddItem(obj);
            return this._mapper.Map<OrderDetailVM>(result);
        }

    }
}