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
        BaseService<ProductVM, Product>,
        IProductService
    {

        private IProductDAO _dao;

        public ProductService(IProductDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _dao = dao;
        }

        public (ICollection<ProductVM>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var result = _dao.GetList(query, typeId, cateId, limited, offset, sort);
            var lsObject = new List<ProductVM>();
            if (result.Item1.Count > 0)
                lsObject = _mapList<ProductVM, Product>(result.Item1);
            return (lsObject, lsObject.Count);
        }

        public ICollection<string> GetImages(int productId, string folderPath)
        {
            var listImage = new List<string>();
            // string folderPath = Path.Combine(webRootPath, "products/" + productId);
            if (!Directory.Exists(folderPath)) return listImage;
            var re = Directory.GetFiles(folderPath);
            foreach (var item in re)
                listImage.Add(item.Split("/").Last());
            return listImage;
        }

        public bool RemoveImage(int productId, string imgName, string folderPath)
        {
            throw new NotImplementedException();
        }

        public bool UploadImage(int productId, string imgName, string folderPath)
        {
            throw new NotImplementedException();
        }
    }
}