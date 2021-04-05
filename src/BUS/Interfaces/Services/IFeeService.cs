using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IFeeService :
        IGet<FeeVM>,
        IGetList<FeeVM>,
        IAdd<FeeVM>,
        IUpdate<FeeVM>,
        IDelete<FeeVM>
    {
    }
}