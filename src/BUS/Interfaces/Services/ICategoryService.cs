using System.Collections.Generic;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface ICategoryService :
        IGet<CategoryVM>,
        IGetList<CategoryVM>,
        IAdd<CategoryVM>,
        IUpdate<CategoryVM>,
        IDelete<CategoryVM>
    {
        CategoryVM Add(int typeProductId, CategoryVM newObject);
        ICollection<CategoryVM> GetList(int typeProductId);
    }
}