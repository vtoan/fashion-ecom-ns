using Shared.ViewModels;

namespace BUS.Interfaces
{
    public interface ITypeProductService :
        IGet<TypeProductVM>,
        IGetList<TypeProductVM>,
        IAdd<TypeProductVM>,
        IUpdate<TypeProductVM>,
        IDelete<TypeProductVM>
    { }
}