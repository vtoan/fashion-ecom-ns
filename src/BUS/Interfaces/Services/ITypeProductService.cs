using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface ITypeProductService :
        IGet<TypeProductVM>,
        IGetList<TypeProductVM>,
        IAdd<TypeProductVM>,
        IUpdate<TypeProductVM>,
        IDelete<TypeProductVM>
    { }
}