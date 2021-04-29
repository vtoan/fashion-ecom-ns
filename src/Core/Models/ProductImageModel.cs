using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class ProductImageModel
    {
        [Required]
        public int Id { get; set; }
        public string Image { get; set; }
    }
}