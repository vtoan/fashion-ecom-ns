using System.Collections.Generic;
using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class CategoryService :
        BaseService<CategoryVM, Category>,
        ICategoryService
    {

        private ICategoryDAO _cateDAO;

        public CategoryService(ICategoryDAO dao, IMapper mapper) : base(dao, mapper)
        {
            _cateDAO = dao;
        }

        public CategoryVM Add(int typeProductId, CategoryVM newObject)
        {
            if (typeProductId <= 0 || newObject == null) return null;
            var newCate = _mapper.Map<Category>(newObject);
            newCate.TypeProductId = typeProductId;
            return _mapper.Map<CategoryVM>(_cateDAO.AddItem(newCate));
        }

        public ICollection<CategoryVM> GetList(int typeProductId)
        {
            return this._mapList<CategoryVM, Category>(_cateDAO.GetListItems(typeProductId));
        }
    }
}