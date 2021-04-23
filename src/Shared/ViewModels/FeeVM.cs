using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class FeeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name fee is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cost fee is required")]
        public double? Cost { get; set; }
    }
}