using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class TypeProductVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}