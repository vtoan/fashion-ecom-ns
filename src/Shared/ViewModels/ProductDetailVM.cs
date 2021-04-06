using System.Collections.Generic;

namespace Shared.ViewModels
{
    public class ProductDetailVM : ProductVM
    {
        public string Material { get; set; }
        public string Origin { get; set; }
        public ICollection<ProductAttributeVM> ProductAttributes { get; set; }
    }
}