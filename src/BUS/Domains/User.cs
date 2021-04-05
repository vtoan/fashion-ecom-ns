
using Microsoft.AspNetCore.Identity;

namespace BUS.Domains
{
    public class User : IdentityUser
    {
        public string CustomerName { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerAddress { get; set; }
        //nav property
        public virtual ICollection<Rating> Ratings { get; set; }

    }
}