using System.ComponentModel.DataAnnotations;
namespace ConfiguredApi.Settings;

public class ApiSettings
{
    [Required]
    [StringLength(100)]
    public string DefaultGreeting { get; set; } = "Greetings";
    public string WelcomeMessage { get; set; } = "Welcome";
    public bool EnableDebugMode { get; set; }
}