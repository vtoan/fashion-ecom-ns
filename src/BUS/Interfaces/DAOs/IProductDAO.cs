using System;
using System.Collections.Generic;
using BUS.Domains;
using Shared.Enums;

namespace BUS.Interfaces.DAOs
{
    public interface IProductDAO : IBaseDAO<Product>
    {
        (ICollection<Product>, int) GetListItems(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
    }
}