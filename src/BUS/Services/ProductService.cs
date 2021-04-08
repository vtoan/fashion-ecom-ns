using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using BUS.Domains;
using BUS.Enums;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class ProductService :
        BaseService<ProductDetailVM, Product>,
        IProductService
    {

        private readonly IProductDAO _productDao;

        public ProductService(IProductDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _productDao = dao;
        }

        public (ICollection<ProductVM>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var result = _productDao.GetListItems(query, typeId, cateId, limited, offset, sort);
            var lsObject = new List<ProductVM>();
            if (result.Item1.Count > 0)
                lsObject = _mapList<ProductVM, Product>(result.Item1);
            return (lsObject, lsObject.Count);
        }

        // public ICollection<string> GetImages(int productId, string folderPath)
        // {
        //     var listImage = new List<string>();
        //     // string folderPath = Path.Combine(webRootPath, "products/" + productId);
        //     if (!Directory.Exists(folderPath)) return listImage;
        //     var re = Directory.GetFiles(folderPath);
        //     foreach (var item in re)
        //         listImage.Add(item.Split("/").Last());
        //     return listImage;
        // }

        public bool RemoveImageDefault(int productId, string imgName)
        {
            if (productId <= 0 || imgName == null || imgName == "") return false;
            var modifiedProps = new Dictionary<string, object>();
            modifiedProps.Add("Image", null);
            return _productDao.UpdateItem(productId, modifiedProps);
        }

        public bool SetImageDefault(int productId, string imgName)
        {
            if (productId <= 0 || imgName == null || imgName == "") return false;
            var modifiedProps = new Dictionary<string, object>();
            modifiedProps.Add("Image", imgName);
            return _productDao.UpdateItem(productId, modifiedProps);
        }
    }
}