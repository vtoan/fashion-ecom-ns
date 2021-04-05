using System.Collections.Generic;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IRatingService :
        IAdd<RatingVM>,
        IDelete<RatingVM>
    {
        ICollection<RatingVM> GetByProduct(int productId);
        ICollection<RatingVM> GetByUser(string userId);
    }
}