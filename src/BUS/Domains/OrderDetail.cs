namespace BUS.Domains
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductAttrId { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        //Nav property
        public Order Order { get; set; }
        public ProductAttr ProductAttr { get; set; }
    }
}