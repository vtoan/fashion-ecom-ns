using System.Collections.Generic;

namespace BUS.Domains
{
    public class TypeProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //nav property
        public ICollection<Product> Products { get; set; }
    }
}