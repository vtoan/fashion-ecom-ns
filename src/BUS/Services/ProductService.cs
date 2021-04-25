using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using BUS.Domains;
using Shared.Enums;
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

        public new ProductDetailVM Add(ProductDetailVM newObject)
        {
            if (newObject.ProductAttributes == null || newObject.ProductAttributes.Count == 0)
            {
                var attrsDefault = new List<ProductAttributeVM>() { new ProductAttributeVM { Size = "FreeSize" } };
                newObject.ProductAttributes = attrsDefault;
            }
            return base.Add(newObject);
        }

        public (ICollection<ProductVM>, int) GetList(string query, int typeId, int cateId, int limited, int offset, ProductSort? sort)
        {
            var result = _productDao.GetListItems(query, typeId, cateId, limited, offset, sort);
            var lsObject = new List<ProductVM>();
            if (result.Item1.Count > 0)
                lsObject = _mapList<ProductVM, Product>(result.Item1);
            return (lsObject, result.Item2);
        }

        public new bool Delete(int productId)
        {
            if (productId <= 0) return false;
            return _productDao.DeleteItem(productId);
        }
    }
}