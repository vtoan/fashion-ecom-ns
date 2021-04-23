using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class OrderVM
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        [Required(ErrorMessage = "Customer name is required")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Customer phone is required")]
        public string CustomerPhone { get; set; }
        public int? CustomerProvince { get; set; }
        [Required(ErrorMessage = "User Id is required")]
        public string UserId { get; set; }
    }
}