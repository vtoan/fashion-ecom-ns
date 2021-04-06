using System;

namespace Shared.ViewModels
{
    public class RatingVM
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Feedback { get; set; }
        public string UserId { get; set; }
    }
}