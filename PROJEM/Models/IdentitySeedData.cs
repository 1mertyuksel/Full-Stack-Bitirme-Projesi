using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PROJEM.Data; // IdentityContext sınıfının tanımlandığı namespace'e göre ekleyin
using PROJEM.Models;

namespace PROJEM.Models
{
    public static class IdentitySeedData
    {
        private const string adminUser = "admin";
        private const string adminPassword = "Admin_123";

        public static async Task IdentityTestUser(IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<IdentityContext>();

                if (context.Database.GetAppliedMigrations().Any())
                {
                    context.Database.Migrate();
                }

                var userManager = services.GetRequiredService<UserManager<AppUser>>();

                var user = await userManager.FindByNameAsync(adminUser);

                if (user == null)
                {
                    user = new AppUser
                    {
                        FullName = "Mert Yüksel",
                        UserName = adminUser, // Kullanıcı adını da belirtmelisiniz
                        Email = "mertyuksel680@gmail.com",
                        PhoneNumber = "5531244941"
                    };

                    await userManager.CreateAsync(user, adminPassword);
                }
            }
        }
    }
}
