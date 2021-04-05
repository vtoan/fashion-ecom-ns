namespace BUS.Domains
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? isDel { get; set; }
        public double? Price { get; set; }
        public int? SaleCount { get; set; }
        public string Image { get; set; }
        public string Material { get; set; }
        public string Origin { get; set; }
        public string ProductDescription { get; set; }
        public int? CategoryId { get; set; }
        public int? TypeID { get; set; }
        //Nav property
        public Type Type { get; set; }
        public Category Category { get; set; }
    }
}