using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class RatingVM
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Feedback { get; set; }
        [Required(ErrorMessage = "Rate is required")]
        public int? Rate { get; set; }
        public string UserId { get; set; }
        public string CustomerName { get; set; }
    }
}