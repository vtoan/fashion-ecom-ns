using AutoMapper;
using BUS.Domains;
using BUS.Interfaces.DAOs;
using BUS.Interfaces.Services;
using Shared.ViewModels;

namespace BUS.Services
{
    public class FeeService :
        BaseService<FeeVM, Fee>,
        IFeeService
    {
        public FeeService(IBaseDAO<Fee> dao, IMapper mapper) : base(dao, mapper)
        {
        }
    }
}