using System;
using System.Collections.Generic;
using BUS.Domains;
using BUS.Enums;

namespace BUS.Interfaces.DAOs
{
    public interface IProductDAO : IBaseDAO<Product>
    {
        (ICollection<Product>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
    }
}