using System.Collections.Generic;

namespace BUS.Domains
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //nav property
        public virtual ICollection<Product> Products { get; set; }
    }
}