using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class ProductImageModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
    }
}