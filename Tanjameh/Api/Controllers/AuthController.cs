using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tanjameh.Api.Models.Auth;
using Tanjameh.Infrastructure.Data; // Use Infrastructure User
using CoreEntities = Tanjameh.Core.Entities; // Alias for Core Customer
using Tanjameh.Features.Customer.Services;
using System.Linq; // For LINQ methods like FirstOrDefault

namespace Tanjameh.Api.Controllers;

public class AuthController : BaseApiController
{
    private readonly AuthenticationService _authenticationService;
    private readonly UserManager<ApplicationUser> _userManager; // Use Infrastructure User
    private readonly ILogger<AuthController> _logger;
    // TODO: Inject a service for JWT token generation

    public AuthController(AuthenticationService authenticationService, UserManager<ApplicationUser> userManager, ILogger<AuthController> logger)
    {
        _authenticationService = authenticationService;
        _userManager = userManager;
        _logger = logger;
    }

    [HttpPost("login")]
    public async Task<ActionResult<AuthResponseDto>> Login(LoginRequestDto request)
    {
        var result = await _authenticationService.LoginAsync(request.Email, request.Password);

        if (result.Succeeded) // Corrected: Use Succeeded property
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            // TODO: Generate JWT token here
            var token = "DUMMY_JWT_TOKEN"; // Placeholder

            _logger.LogInformation("User {Email} logged in successfully.", request.Email);
            return Ok(new AuthResponseDto
            {
                Success = true,
                Token = token,
                User = user != null ? new UserDto { Id = user.Id, Email = user.Email } : null
            });
        }
        else
        {
            string message = "Invalid login attempt.";
            if (result.IsLockedOut)
            {
                message = "User account locked out.";
                _logger.LogWarning("Login failed for {Email}: Account locked out.", request.Email);
            }
            else if (result.IsNotAllowed)
            {
                message = "User is not allowed to sign in.";
                 _logger.LogWarning("Login failed for {Email}: Not allowed.", request.Email);
            }
            else if (result.RequiresTwoFactor)
            {
                message = "Two-factor authentication required.";
                 _logger.LogWarning("Login failed for {Email}: Requires 2FA.", request.Email);
            }
            else
            {
                 _logger.LogWarning("Login failed for {Email}: Invalid credentials.", request.Email);
            }
            // Corrected: Use custom message based on result status
            return Unauthorized(new AuthResponseDto { Success = false, Message = message });
        }
    }

    [HttpPost("register")]
    public async Task<ActionResult<AuthResponseDto>> Register(RegisterRequestDto request)
    {
        if (request.Password != request.ConfirmPassword)
        {
            return BadRequest(new AuthResponseDto { Success = false, Message = "Passwords do not match." });
        }

        // Create a minimal Customer object for registration
        var customerInfo = new CoreEntities.Customer
        {
            FirstName = request.FirstName ?? "", // Use provided or default
            LastName = request.LastName ?? "",   // Use provided or default
            Email = request.Email
            // Add other required fields if necessary, e.g., default address
        };

        // Corrected: Call RegisterUserAsync and pass customerInfo
        var result = await _authenticationService.RegisterUserAsync(request.Email, request.Password, customerInfo);

        if (result.Succeeded) // Corrected: Use Succeeded property
        {
             var user = await _userManager.FindByEmailAsync(request.Email);
            // TODO: Generate JWT token here
            var token = "DUMMY_JWT_TOKEN"; // Placeholder

            _logger.LogInformation("User {Email} registered successfully.", request.Email);
            return Ok(new AuthResponseDto
            {
                Success = true,
                Token = token,
                User = user != null ? new UserDto { Id = user.Id, Email = user.Email } : null
                // Optionally return confirmation message if email verification is needed
            });
        }
        else
        {
            // Corrected: Get error messages from IdentityResult
            var errorMessage = result.Errors.FirstOrDefault()?.Description ?? "User registration failed.";
            _logger.LogWarning("Registration failed for {Email}: {Error}", request.Email, errorMessage);
            return BadRequest(new AuthResponseDto { Success = false, Message = errorMessage });
        }
    }
}

