using System;
using System.Collections.Generic;
using System.Linq;
using BUS.Domains;
using Shared.Enums;
using BUS.Interfaces.DAOs;
using Microsoft.EntityFrameworkCore;

namespace DAO.DAOs
{
    public class UserDAO :
        BaseDAO<User>,
        IUserDAO
    {
        public UserDAO(AppDbContext context) : base(context)
        { }

        public (ICollection<User> Users, int TotalItem) GetListItems(string query, int limited, int offset)
        {
            var sqlString = this._context.Users.AsQueryable();
            //filter
            if (query != null) sqlString = sqlString.Where(item => item.Email.Contains(query));
            var totalItem = sqlString.Count();
            if (offset > 0)
            {
                if (offset * limited > totalItem) throw new Exception("Offset is outbound");
                sqlString = sqlString.Skip(offset * limited);
            }
            if (limited > 0)
            {
                if (offset * limited <= totalItem)
                    sqlString = sqlString.Take(limited);
            }
            //sort
            var result = sqlString.ToList();
            return (result, totalItem);
        }
    }
}