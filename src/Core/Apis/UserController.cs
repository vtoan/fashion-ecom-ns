using Shared.Enums;
using BUS.Interfaces.Services;
using Core.Helper;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ViewModels;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize("Bearer")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userSer;

        public UserController(IUserService userSer)
        {
            _userSer = userSer;
        }


        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<UserVM> GetList(int limited, int offset, string query = null)
        {
            var result = _userSer.GetList(query, limited, offset);
            RespHelper.AddTotalPage(HttpContext, result.TotalItem);
            return result.Users;
        }
    }
}