using System;
using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Enums;
using BUS.Interfaces.DAOs;
using Microsoft.EntityFrameworkCore;

namespace DAO.DAOs
{
    public class OrderDAO : IOrderDAO
    {
        private readonly AppDbContext _context;

        public Order AddItem(Order newObject)
        {
            if (newObject == null) return null;
            _context.Add<Order>(newObject);
            _context.SaveChangesAsync().Wait();
            return newObject;
        }

        public Order GetItem(int id)
        {
            if (id <= 0) return null;
            return _context.Set<Order>()
                .Where(item => item.Id == id)
                .Include(item => item.OrderDetails)
                .FirstOrDefault();
        }

        public (ICollection<Order>, int) GetList(DateTime start, DateTime end, int provinceId, int limited, int offset)
        {
            var sqlQuery = _context.Orders.Where(item => item.DateCreated >= start && item.DateCreated <= end);
            var totalItem = sqlQuery.Count();
            _getListOrder(sqlQuery, totalItem, provinceId, limited, offset);
            var result = sqlQuery.ToList();
            return (result, totalItem);
        }



        public (ICollection<Order>, int) GetListByPhone(string query, int provinceId, int limited, int offset)
        {
            var sqlQuery = _context.Orders.Where(item => item.CustomerPhone.Contains(query));
            var totalItem = sqlQuery.Count();
            _getListOrder(sqlQuery, totalItem, provinceId, limited, offset);
            var result = sqlQuery.ToList();
            return (result, totalItem);
        }

        public (ICollection<Order>, int) GetListByUser(string userId, int provinceId, int limited, int offset)
        {
            var sqlQuery = _context.Orders.Where(item => item.UserId == userId);
            var totalItem = sqlQuery.Count();
            _getListOrder(sqlQuery, totalItem, provinceId, limited, offset);
            var result = sqlQuery.ToList();
            return (result, totalItem);
        }

        private void _getListOrder(IQueryable<Order> src, int total, int provinceId, int limited, int offset)
        {
            if (provinceId != 0) src = src.Where(item => item.CustomerProvince == provinceId);
            if (offset > 0)
            {
                if (offset > total) throw new Exception("Offset is outbound");
                src = src.Skip(offset);
            }
            if (limited > 0)
            {
                if (offset * limited <= total)
                    src = src.Take(limited);
            }
            src.OrderByDescending(item => item.DateCreated);
        }
    }
}