using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class TypeProductService :
        BaseService<TypeProductVM, TypeProduct>,
        ITypeProductService
    {
        public TypeProductService(IBaseDAO<TypeProduct> dao, IMapper mapper) : base(dao, mapper)
        {
        }
    }
}