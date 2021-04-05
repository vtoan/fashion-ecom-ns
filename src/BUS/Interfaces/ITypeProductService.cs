using Shared.ViewModels;

namespace BUS.Interfaces
{
    public interface ICategoryService :
        IGet<CategoryVM>,
        IGetList<CategoryVM>,
        IAdd<CategoryVM>,
        IUpdate<CategoryVM>,
        IDelete<CategoryVM>
    { }
}