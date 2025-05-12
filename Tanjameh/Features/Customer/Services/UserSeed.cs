namespace Tanjameh.Features.Customer.Services;

// UserSeed.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Tanjameh.Infrastructure.Data;

public static class UserSeed
{
    public static async Task SeedAdminUser(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<long>>>();

            const string adminEmail = "opensblog@gmail.com";
            const string adminPassword = "1qaz#EDC";

            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(adminUser, adminPassword);

                if (result.Succeeded)
                {
                    if (!await roleManager.RoleExistsAsync("Admin"))
                    {
                        await roleManager.CreateAsync(new IdentityRole<long>("Admin"));
                    }
                    // Ensure Customer role exists
                    if (!await roleManager.RoleExistsAsync("Customer"))
                    {
                        await roleManager.CreateAsync(new IdentityRole<long>("Customer"));
                    }

                    await userManager.AddToRoleAsync(adminUser, "Admin");

                    // Create corresponding Customer record
                    var customerService = scope.ServiceProvider.GetRequiredService<CustomerService>();
                    await customerService.CreateCustomerAsync(new Core.Entities.Customer
                    {
                        UserId = adminUser.Id,
                        FirstName = "Admin",
                        LastName = "User",
                        Email = adminEmail,
                        IsActive = true,
                        CreatedTime = DateTime.UtcNow
                    });
                }
            }
        }
    }
}