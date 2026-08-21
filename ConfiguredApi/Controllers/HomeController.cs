using Microsoft.AspNetCore.Mvc;

namespace ConfiguredApi.Controllers;
[ApiController]
[Route("")]
public class HomeController : Controller
{
    private readonly IConfiguration _config;

    public HomeController(IConfiguration config)
    {
        _config = config;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        var greeting = _config["DefaultGreeting"] ?? "Untitled";
            
        return Ok(new
        {
            Title = greeting,
            TimestampUtc = DateTime.UtcNow
        });
    }
}