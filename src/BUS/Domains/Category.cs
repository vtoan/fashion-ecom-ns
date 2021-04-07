using System.Collections.Generic;

namespace BUS.Domains
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? TypeProductId { get; set; }
        //nav property
        public ICollection<Product> Products { get; set; }
    }
}