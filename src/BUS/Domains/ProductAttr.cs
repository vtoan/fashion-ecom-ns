namespace BUS.Domains
{
    public class ProductAttr
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public int? ProductId { get; set; }
        //Nav property
        public Product Product { get; set; }
    }
}