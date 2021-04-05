namespace BUS.Domains
{
    public class OrderDetail
    {
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
        public double? Discount { get; set; }
        //Nav property
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}