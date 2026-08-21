using ConfiguredApi.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfiguredApi.Controllers;
[ApiController]
[Route("")]
public class HomeController : ControllerBase
{
    private readonly AppSettings _settings;

    // Use constructor injection (recommended for singleton-scoped settings)
    public HomeController(IOptions<AppSettings> options)
    {
        _settings = options.Value;
    }

    // Or inject directly (cleaner syntax)
    [HttpGet("")]
    public IActionResult Index([FromServices] IOptions<AppSettings> options)
    {
        var settings = options.Value;
            
        return Ok(new
        {
            Title = settings.DefaultGreeting,
            DebugEnabled = settings.EnableDebugMode,
            Timestamp = DateTime.UtcNow
        });
    }
}