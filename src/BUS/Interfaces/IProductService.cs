using System;
using System.Collections.Generic;
using BUS.Domains;
using BUS.Enums;
using Shared.ViewModels;

namespace BUS.Interfaces
{
    public interface IProductService :
        IGet<ProductVM>,
        IAdd<ProductVM>,
        IUpdate<ProductVM>,
        IDelete<ProductVM>
    {
        // Tuple <Products, Numbers>
        Tuple<ICollection<ProductVM>, int> GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort sort);
        bool UploadImage(int productId, string imgName);
        bool RemoveImage(int productId, string imgName);
    }
}