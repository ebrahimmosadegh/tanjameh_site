using Microsoft.AspNetCore.Mvc;

namespace Tanjameh.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    // Common functionalities for API controllers can be added here
    // For example, standardized error handling or user context retrieval
}

