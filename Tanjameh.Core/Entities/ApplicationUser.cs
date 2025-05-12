using Microsoft.AspNetCore.Identity;

namespace Tanjameh.Core.Entities;

/// <summary>
/// Represents an application user, extending the base IdentityUser.
/// </summary>
public class ApplicationUser : IdentityUser<long> // Using long as the key type to match Customer.UserId
{
    // Add any additional properties for the user here, if needed.
    // For example:
    // public string? FirstName { get; set; }
    // public string? LastName { get; set; }
    // public DateTime DateOfBirth { get; set; }
}

