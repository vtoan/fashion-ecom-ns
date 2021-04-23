using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class OrderItemVM
    {
        [Required(ErrorMessage = "Attribute Id is required")]
        public int AttributeId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "Price is is required")]
        public double? Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
    }
}