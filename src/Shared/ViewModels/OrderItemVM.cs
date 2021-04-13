namespace Shared.ViewModels
{
    public class OrderItemVM
    {
        public int AttributeId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
    }
}