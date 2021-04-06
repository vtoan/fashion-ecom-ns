namespace Shared.ViewModels
{
    public class OrderItemVM
    {
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public double? Discount { get; set; }
    }
}