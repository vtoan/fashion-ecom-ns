using System;

namespace Shared.ViewModels
{
    public class OrderVM
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public int CustomerProvince { get; set; }
        public string UserId { get; set; }
    }
}