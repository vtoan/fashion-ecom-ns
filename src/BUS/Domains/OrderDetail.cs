namespace BUS.Domains
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductDetailId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
        //Nav property
        public Order Order { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}