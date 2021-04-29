using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shared.ViewModels
{
    public class OrderDetailVM : OrderVM
    {
        public string CustomerEmail { get; set; }
        [Required]
        public int? CustomerDistrict { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        public string Note { get; set; }
        public string Promotions { get; set; }
        public string Fees { get; set; }
        public ICollection<OrderItemVM> OrderItems { get; set; }

    }
}