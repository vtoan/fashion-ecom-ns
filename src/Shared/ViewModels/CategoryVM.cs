using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name category is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Typeproduct of category is required")]
        public int? TypeProductId { get; set; }
    }
}