using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tanjameh.Infrastructure.Data; // Use Infrastructure User for Identity
using CoreEntities = Tanjameh.Core.Entities; // Alias for Core Customer entity

namespace Tanjameh.Features.Customer.Services;

// Changed from internal to public to allow usage in public AuthController
public class AuthenticationService
{
    // Use Infrastructure.Data.ApplicationUser consistently for Identity operations
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly CustomerService _customerService;
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly ILogger<AuthenticationService> _logger;
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;

    public AuthenticationService(
        UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        CustomerService customerService,
        AuthenticationStateProvider authenticationStateProvider,
        ILogger<AuthenticationService> logger,
        IDbContextFactory<ApplicationDbContext> contextFactory)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _customerService = customerService;
        _authenticationStateProvider = authenticationStateProvider;
        _logger = logger;
        _contextFactory = contextFactory;
    }


    public async Task<IdentityResult> RegisterUserAsync(string email, string password, CoreEntities.Customer customerInfo)
    {
        // Use Infrastructure.Data.ApplicationUser for creating user
        var user = new ApplicationUser { UserName = email, Email = email };
        var result = await _userManager.CreateAsync(user, password);

        if (result.Succeeded)
        {
            // Assign Customer role
            await _userManager.AddToRoleAsync(user, "Customer");

            // Core.Entities.Customer still uses long UserId
            customerInfo.UserId = user.Id;
            customerInfo.Email = email;
            await _customerService.CreateCustomerAsync(customerInfo);
            await _signInManager.SignInAsync(user, isPersistent: false);
        }

        return result;
    }

    public async Task<bool> CheckUserExsit(string email)
    {
        return await _userManager.Users.AnyAsync(x => x.NormalizedEmail == email.Normalize());

    }

    public async Task<SignInResult> LoginAsync(string email, string password)
    {
       return await _signInManager.PasswordSignInAsync(email, password, isPersistent: false, lockoutOnFailure: false);

    }

    public async Task LogoutAsync()
    {
        await _signInManager.SignOutAsync();
    }

    // Returns Core.Entities.Customer
    public async Task<CoreEntities.Customer?> GetCurrentUserAsync()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity?.IsAuthenticated == true)
        {
            var applicationUser = await GetApplicationUserAsync(user);
            if (applicationUser != null)
            {
                // CustomerService expects long UserId
                return await _customerService.GetCustomerByUserIdAsync(applicationUser.Id);
            }
        }

        return null;
    }

    // Returns Infrastructure.Data.ApplicationUser
    private async Task<ApplicationUser?> GetApplicationUserAsync(ClaimsPrincipal user)
    {
        var userId = user.FindFirstValue(ClaimTypes.NameIdentifier);
        if (!string.IsNullOrEmpty(userId))
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            if (long.TryParse(userId, out var parsedUserId))
            {
                 // FindAsync returns Infrastructure.Data.ApplicationUser from DbContext
                 return await context.Users.FindAsync(parsedUserId);
            }
        }
        return null;
    }
}
