using System;

namespace BUS.Domains
{
    public class Rating
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Feedback { get; set; }
        // nav property
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}