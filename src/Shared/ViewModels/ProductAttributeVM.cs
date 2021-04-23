using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class ProductAttributeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Size is required")]
        public string Size { get; set; }
    }
}