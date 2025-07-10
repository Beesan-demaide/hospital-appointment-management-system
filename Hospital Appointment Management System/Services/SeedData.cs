
/*using Hospital_Appointment_Management_System.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Hospital_Appointment_Management_System.Services
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<User> userManager, RoleManager<IdentityRole<int>> roleManager)
        {
            string[] roleNames = {"Admin","Doctor","Patient" };
            foreach (var roleName in roleNames)
            {
                var role = await roleManager.FindByNameAsync(roleName);
                if (role == null)
                {
                    var roleResult = await roleManager.CreateAsync(new IdentityRole<int>(roleName));
                    if (!roleResult.Succeeded)
                    {
                        throw new Exception("Can not add new Role");
                    }
                }
            }
            var adminUser = await userManager.FindByEmailAsync("admin@gmail.com");
            if (adminUser == null)
            {
                var user = new User
                {
                    UserName = "Admin",
                    Email = "admin@gmail.com"
                };
                var result = await userManager.CreateAsync(user,"Password#123");
                if (result.Succeeded)
                {                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }
    }
}

*/
