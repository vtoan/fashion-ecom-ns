using System.Collections.Generic;
using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class UserService : BaseService<UserVM, User>, IUserService
    {
        private readonly IUserDAO _userDao;

        public UserService(IUserDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _userDao = dao;
        }

        public (ICollection<UserVM> Users, int TotalItem) GetList(string query, int limited, int offset)
        {
            var result = _userDao.GetListItems(query, limited, offset);
            var lsObject = new List<UserVM>();
            if (result.Item1.Count > 0)
                lsObject = _mapList<UserVM, User>(result.Users);
            return (lsObject, result.TotalItem);
        }
    }
}