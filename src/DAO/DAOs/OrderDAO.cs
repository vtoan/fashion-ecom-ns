using System;
using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using Microsoft.EntityFrameworkCore;

namespace DAO.DAOs
{
    public class OrderDAO :
        BaseDAO<Order>,
        IOrderDAO
    {
        public OrderDAO(AppDbContext context) : base(context)
        {
        }

        public new Order AddItem(Order newObject)
        {
            if (newObject == null) return null;
            _context.Add<Order>(newObject);
            if (newObject.OrderDetails.Count > 0)
            {
                foreach (var od in newObject.OrderDetails)
                {
                    var product = _context.ProductAttrs.Find(od.ProductAttrId);
                    if (product != null) product.SaleCount += od.Quantity;
                }
            }
            _context.SaveChangesAsync().Wait();
            return newObject;
        }

        public new Order GetItem(int id)
        {
            if (id <= 0) return null;
            return _context.Set<Order>()
                .Where(item => item.Id == id)
                .Include(item => item.OrderDetails)
                .ThenInclude(item => item.ProductAttr)
                .ThenInclude(item => item.Product)
                .FirstOrDefault();
        }

        public (ICollection<Order>, int) GetListItems(DateTime start, DateTime end, int provinceId, int limited, int offset)
        {
            var sqlQuery = _context.Orders.Where(item => item.DateCreated >= start && item.DateCreated <= end);
            var totalItem = sqlQuery.Count();
            _getListOrder(sqlQuery, totalItem, provinceId, limited, offset);
            var result = sqlQuery.ToList();
            return (result, totalItem);
        }



        public (ICollection<Order>, int) GetListItemsByPhone(string query, int provinceId, int limited, int offset)
        {
            var sqlQuery = _context.Orders.Where(item => item.CustomerPhone.Contains(query));
            var totalItem = sqlQuery.Count();
            _getListOrder(sqlQuery, totalItem, provinceId, limited, offset);
            var result = sqlQuery.ToList();
            return (result, totalItem);
        }

        public (ICollection<Order>, int) GetListItemsByUser(string userId, int provinceId, int limited, int offset)
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