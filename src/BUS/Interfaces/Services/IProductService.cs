using System.Collections.Generic;
using BUS.Enums;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IProductService :
        IGet<ProductDetailVM>,
        IAdd<ProductDetailVM>,
        IUpdate<ProductDetailVM>,
        IDelete<ProductDetailVM>
    {
        // Tuple <Products, Numbers>
        (ICollection<ProductVM>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort);
        bool UploadImage(int productId, string imgName, string folderPath);
        bool RemoveImage(int productId, string imgName, string folderPath);
        // ICollection<string> GetImages(int productId, string folderPath);
    }
}