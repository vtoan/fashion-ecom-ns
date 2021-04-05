namespace BUS.Domains
{
    public class Rating
    {
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int DateCreated { get; set; }
        public int Feedback { get; set; }
        // nav property
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}