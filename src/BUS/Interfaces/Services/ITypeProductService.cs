using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface ICategoryService :
        IGet<CategoryVM>,
        IGetList<CategoryVM>,
        IAdd<CategoryVM>,
        IUpdate<CategoryVM>,
        IDelete<CategoryVM>
    { }
}