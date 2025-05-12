using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System; // Required for Exception
using System.Threading.Tasks;
// using Tanjameh.Core.Interfaces; // Add interface for batch update service later

namespace Tanjameh.Api.Controllers
{
    /// <summary>
    /// Controller for triggering background data synchronization tasks.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<UpdateController> _logger;
        // Inject IBatchProductUpdateService later
        // private readonly IBatchProductUpdateService _batchUpdateService;

        // Define the expected API key header name
        private const string ApiKeyHeaderName = "X-API-Key";

        public UpdateController(IConfiguration configuration, ILogger<UpdateController> logger /*, IBatchProductUpdateService batchUpdateService */)
        {
            _configuration = configuration;
            _logger = logger;
            // _batchUpdateService = batchUpdateService;
        }

        /// <summary>
        /// Triggers a background update process for product prices and availability.
        /// </summary>
        /// <remarks>
        /// Documentation:
        /// Purpose: Initiates a full background check and update for all active products from their sources (Asos, Zalando, Next).
        ///          Updates price and availability based on the latest data.
        /// Usage: Call this endpoint via a POST request, typically triggered by an external scheduler (e.g., cron job).
        /// Security: Requires a valid API key passed in the 'X-API-Key' header. Configure the expected key in appsettings.json under 'AppSettings:ApiKey'.
        /// Response: Returns 202 Accepted if the update process is initiated successfully, 401 Unauthorized if the API key is missing or invalid, 500 Internal Server Error if initiation fails.
        /// Note: This endpoint initiates the process, which may run for a significant time in the background. It does not wait for completion.
        /// </remarks>
        /// <returns>IActionResult indicating the outcome.</returns>
        [HttpPost("trigger-product-update")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> TriggerProductUpdate()
        {
            // 1. Authentication Check
            if (!Request.Headers.TryGetValue(ApiKeyHeaderName, out var extractedApiKey))
            {
                _logger.LogWarning("API key was not provided in header: {HeaderName}", ApiKeyHeaderName);
                return Unauthorized("API key required.");
            }

            var expectedApiKey = _configuration.GetValue<string>("AppSettings:ApiKey");
            if (string.IsNullOrEmpty(expectedApiKey) || !expectedApiKey.Equals(extractedApiKey))
            {
                _logger.LogWarning("Invalid API key provided.");
                return Unauthorized("Invalid API key.");
            }

            _logger.LogInformation("TriggerProductUpdate endpoint called with valid API key.");

            // 2. Initiate Update Process (Placeholder - requires BatchProductUpdateService)
            try
            {
                _logger.LogInformation("Initiating background product update process...");
                // In a real scenario, use a background job system (like Hangfire) or an IHostedService
                // For now, simulate initiation and return Accepted.
                // await _batchUpdateService.StartFullProductUpdateAsync(); // Call the actual service method here
                
                // Simulate asynchronous initiation without awaiting completion
                _ = Task.Run(() => {
                     _logger.LogInformation("Simulated background update task started."); 
                     // Add actual call to the service method here inside the Task.Run
                     Task.Delay(5000).Wait(); // Simulate work
                     _logger.LogInformation("Simulated background update task finished."); 
                 });

                _logger.LogInformation("Background product update process initiated successfully.");
                return Accepted("Product update process initiated.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to initiate product update process.");
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to initiate update process.");
            }
        }
    }
}

