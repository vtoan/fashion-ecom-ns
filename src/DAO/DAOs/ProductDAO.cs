using System;
using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using Shared.Enums;
using BUS.Interfaces.DAOs;
using Microsoft.EntityFrameworkCore;

namespace DAO.DAOs
{
    public class ProductDAO :
        BaseDAO<Product>,
        IProductDAO
    {
        public ProductDAO(AppDbContext context) : base(context)
        { }

        public new Product AddItem(Product newObject)
        {
            newObject.DateCreated = DateTime.Now;
            return base.AddItem(newObject);
        }

        public new bool UpdateItem(int id, Dictionary<string, object> newObject)
        {
            newObject.Add("DateModified", DateTime.Now);
            return base.UpdateItem(id, newObject);
        }

        public new Product GetItem(int id)
        {
            if (id <= 0) return null;
            var sqlQuery = _context.Products.Where(item => item.Id == id)
                .Include(item => item.ProductAttrs)
                .Include(item => item.Ratings);
            return sqlQuery.FirstOrDefault();
        }

        public (ICollection<Product>, int) GetListItems(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var sqlString = this._context.Products.Where(item => item.isDel != true);
            //filter
            if (query != null) sqlString = sqlString.Where(item => item.Name.Contains(query));
            if (typeId > 0) sqlString = sqlString.Where(item => item.TypeProductId == typeId);
            if (cateId > 0) sqlString = sqlString.Where(item => item.CategoryId == cateId);
            var totalItem = sqlString.Count();
            //sort
            if (sort != null)
            {
                switch (sort)
                {
                    case ProductSort.HighPrice:
                        sqlString = sqlString.OrderByDescending(item => item.Price);
                        break;
                    case ProductSort.LowPrice:
                        sqlString = sqlString.OrderBy(item => item.Price);
                        break;
                    case ProductSort.Popular:
                        sqlString = sqlString.OrderByDescending(item => item.ProductAttrs.Sum(i => i.SaleCount));
                        break;
                }
            }
            //paging
            if (offset > 0)
            {
                if (offset * limited > totalItem) throw new Exception("Offset is outbound");
                sqlString = sqlString.Skip(offset * limited);
            }
            if (limited > 0) sqlString = sqlString.Take(limited);

            var result = sqlString.Include(item => item.Ratings).ToList();
            return (result, totalItem);
        }

        public new bool DeleteItem(int id)
        {
            if (id <= 0) return false;
            var productInOrder = _context.OrderDetails.Include(item => item.ProductAttr).Where(item => item.ProductAttr.ProductId == id).FirstOrDefault();
            var obj = _context.Products.Find(id);
            if (productInOrder == null) _context.Remove(obj);
            else obj.isDel = true;
            _context.SaveChangesAsync().Wait();
            return true;
        }
    }
}