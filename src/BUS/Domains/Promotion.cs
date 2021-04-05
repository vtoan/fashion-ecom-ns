using System;

namespace BUS.Domains
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public bool? isAll { get; set; }
        public double? Discount { get; set; }
        public string TypeIds { get; set; }
        public string CateIds { get; set; }
        public string ProductIds { get; set; }
    }
}