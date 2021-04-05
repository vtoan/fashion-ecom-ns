namespace BUS.Domains
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int? ProductId { get; set; }
        //Nav property
        public virtual Product Product { get; set; }
    }
}