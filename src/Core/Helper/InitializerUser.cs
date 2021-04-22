using System.Linq;
using System.Threading.Tasks;
using BUS.Domains;
using Microsoft.AspNetCore.Identity;

namespace Core.Helper
{
    public static class InitializerUser
    {
        public static async Task Initialize(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("admin").Result)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }

            var defaultUser = new User
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
            };
            if (userManager.Users.Count(u => u.Email == defaultUser.Email) == 0)
            {
                IdentityResult result = await userManager.CreateAsync(defaultUser, "Pass123$");
                if (result.Succeeded)
                {
                    var user = await userManager.FindByEmailAsync("admin@gmail.com");
                    await userManager.AddToRoleAsync(user, "admin");
                }
            }
        }
    }
}