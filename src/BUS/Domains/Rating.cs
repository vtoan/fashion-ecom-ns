using System;

namespace BUS.Domains
{
    public class Rating
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Feedback { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        // nav property
        public User User { get; set; }
        public Product Product { get; set; }
    }
}