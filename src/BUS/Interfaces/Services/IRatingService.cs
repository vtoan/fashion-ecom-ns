using System.Collections.Generic;
using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IRatingService :
        // IAdd<RatingVM>,
        IDelete<RatingVM>
    {
        RatingVM Add(int productId, string userId, RatingVM newObject);
        ICollection<RatingVM> GetByProduct(int productId);
        ICollection<RatingVM> GetByUser(string userId);
    }
}