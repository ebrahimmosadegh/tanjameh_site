namespace Tanjameh.Api.Models.Auth;

public class LoginRequestDto
{
    public required string Email { get; set; }
    public required string Password { get; set; }
}

public class RegisterRequestDto
{
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string ConfirmPassword { get; set; }
    // Added FirstName and LastName as required by AuthController
    public string? FirstName { get; set; } // Make nullable or add required based on actual need
    public string? LastName { get; set; }  // Make nullable or add required based on actual need
}

public class AuthResponseDto
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public string? Token { get; set; } // For JWT or other token-based auth
    public UserDto? User { get; set; }
}

public class UserDto
{
    public long Id { get; set; }
    public string? Email { get; set; }
    // Add other user details to return
}

