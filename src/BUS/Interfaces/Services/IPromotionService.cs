using Shared.ViewModels;

namespace BUS.Interfaces.Services
{
    public interface IPromotionService :
        IGet<PromotionVM>,
        IGetList<PromotionVM>,
        IAdd<PromotionVM>,
        IUpdate<PromotionVM>,
        IDelete<PromotionVM>
    {
        bool AddProductProm(int promId, int[] productIds);
        bool RemoveProductProm(int promId, int[] productIds);
    }
}