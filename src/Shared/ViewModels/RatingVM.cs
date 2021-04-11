using System;

namespace Shared.ViewModels
{
    public class RatingVM
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Feedback { get; set; }
        public int? Rate { get; set; }
        public string UserId { get; set; }
        public string CustomerName { get; set; }
    }
}