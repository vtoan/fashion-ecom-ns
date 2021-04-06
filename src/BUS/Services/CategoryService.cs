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
        public CategoryService(IBaseDAO<Category> dao, IMapper mapper) : base(dao, mapper)
        {
        }
    }
}