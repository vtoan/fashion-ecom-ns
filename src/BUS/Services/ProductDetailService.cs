using System.Collections.Generic;
using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class ProductDetailService :
        BaseService<ProductAttributeVM, ProductDetail>,
        IProductDetailService
    {
        private readonly IProductDetailDAO _producDetailDao;

        public ProductDetailService(IProductDetailDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _producDetailDao = dao;
        }
        public ProductAttributeVM Add(int productId, ProductAttributeVM newObject)
        {
            if (productId <= 0) return null;
            var productDetail = _mapper.Map<ProductDetail>(newObject);
            productDetail.ProductId = productId;
            var result = _producDetailDao.AddItem(productDetail);
            return _mapper.Map<ProductAttributeVM>(result);
        }

        public ICollection<ProductAttributeVM> GetList(int productId)
        {
            var result = _producDetailDao.GetListItems(productId);
            return _mapList<ProductAttributeVM, ProductDetail>(result);
        }

        public ICollection<CartItemVM> GetListCartItem(int[] productAttrIds)
        {
            var result = _producDetailDao.GetListCartItem(productAttrIds);
            return _mapList<CartItemVM, ProductDetail>(result);
        }
    }
}