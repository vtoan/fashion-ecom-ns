
using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name product is is required")]
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Category Id product is is required")]
        public int? CategoryId { get; set; }
        [Required(ErrorMessage = "Type product Id product is is required")]

        public int? TypeProductId { get; set; }
        public double? Rate { get; set; }

    }
}