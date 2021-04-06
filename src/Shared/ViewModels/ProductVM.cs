using System.Collections.Generic;

namespace Shared.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double? Price { get; set; }
        public string Image { get; set; }
        public string ProductDescription { get; set; }
        public int? CategoryId { get; set; }
        public int? TypeProductId { get; set; }
        public ICollection<RatingVM> Ratings { get; set; }

    }
}