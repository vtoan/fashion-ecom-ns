using System;
using System.Collections.Generic;

namespace BUS.Domains
{
    public class Order
    {
        public string Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerAddress { get; set; }
        public string Note { get; set; }
        public string Promotions { get; set; }
        public string Fees { get; set; }
        public int? UserId { get; set; }
        //Nav property
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}