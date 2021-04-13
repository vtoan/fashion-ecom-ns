using System.Collections.Generic;
using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class ProductAttrService :
        BaseService<ProductAttributeVM, ProductAttr>,
        IProductAttrService
    {
        private readonly IProductAttrDAO _producAttrlDao;

        public ProductAttrService(IProductAttrDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _producAttrlDao = dao;
        }

        public ProductAttributeVM Add(int productId, ProductAttributeVM newObject)
        {
            if (productId <= 0) return null;
            var productDetail = _mapper.Map<ProductAttr>(newObject);
            productDetail.ProductId = productId;
            var result = _producAttrlDao.AddItem(productDetail);
            return _mapper.Map<ProductAttributeVM>(result);
        }

        public ICollection<ProductAttributeVM> GetList(int productId)
        {
            var result = _producAttrlDao.GetListItems(productId);
            return _mapList<ProductAttributeVM, ProductAttr>(result);
        }

        public ICollection<OrderItemVM> GetListCartItem(int[] productAttrIds)
        {
            var result = _producAttrlDao.GetListCartItem(productAttrIds);
            return _mapList<OrderItemVM, ProductAttr>(result);
        }
    }
}