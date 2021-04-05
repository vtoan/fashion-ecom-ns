using Shared.ViewModels;

namespace BUS.Interfaces
{
    public interface IFeeService :
        IGet<FeeVM>,
        IGetList<CategoryVM>,
        IAdd<CategoryVM>,
        IUpdate<CategoryVM>,
        IDelete<CategoryVM>
    {
    }
}