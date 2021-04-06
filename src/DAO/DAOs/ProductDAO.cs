using System;
using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using BUS.Enums;
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

        public new Product GetItem(int id)
        {
            if (id <= 0) return null;
            var sqlQuery = _context.Products.Where(item => item.Id == id)
                .Include(item => item.ProductDetails)
                .Include(item => item.Ratings);
            return sqlQuery.FirstOrDefault();
        }

        public (ICollection<Product>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var sqlString = this._context.Products.AsQueryable();
            var totalItem = sqlString.Count();
            //filter
            if (query != null) sqlString = sqlString.Where(item => item.Name.Contains(query));
            if (typeId > 0) sqlString = sqlString.Where(item => item.TypeProductId == typeId);
            if (cateId > 0) sqlString = sqlString.Where(item => item.CategoryId == cateId);
            if (offset > 0)
            {
                if (offset > totalItem) throw new Exception("Offset is outbound");
                sqlString = sqlString.Skip(offset);
            }
            if (limited > 0)
            {
                if (offset * limited <= totalItem)
                    sqlString = sqlString.Take(limited);
            }
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
                        sqlString = sqlString.OrderByDescending(item => item.SaleCount);
                        break;
                }
            }
            var result = sqlString.Include(item => item.Ratings).ToList();
            return (result, totalItem);
        }
    }
}