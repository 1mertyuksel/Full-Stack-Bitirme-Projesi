using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace PROJEM.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "Admin";
        private const string adminPassword = "Admin123";

        public static async Task IdentityTestUser(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<DbContext>(); // DbContext tipini kullan
                var userManager = services.GetRequiredService<UserManager<AppUser>>();
                
                if (context.Database.GetAppliedMigrations().Any())
                {
                    context.Database.Migrate();
                }

                var user = await userManager.FindByNameAsync(adminUser);

                if (user == null)
                {
                    user = new AppUser
                    {
                        FullName = "Mert Yüksel",
                        UserName = adminUser,
                        Email = "mertyuksel680@gmail.com",
                        PhoneNumber = "05531244941"
                    };

                    await userManager.CreateAsync(user, adminPassword);
                }
            }
        }
    }
}
