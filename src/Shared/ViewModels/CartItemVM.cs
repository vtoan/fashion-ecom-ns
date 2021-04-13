namespace Shared.ViewModels
{
    public class CartItemVM
    {
        public int ProductId { get; set; }
        public int AttributeId { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
    }
}