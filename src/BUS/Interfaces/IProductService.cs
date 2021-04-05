using System;
using System.Collections.Generic;
using BUS.Domains;
using BUS.Enums;

namespace BUS.Interfaces
{
    public interface IProductService :
        IGet<Product>,
        IAdd<Product>,
        IUpdate<Product>,
        IDelete<Product>
    {
        // Tuple <Products, Numbers>
        Tuple<ICollection<Product>, int> GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort sort);
        bool UploadImage(int productId, string imgName);
        bool RemoveImage(int productId, string imgName);
    }
}