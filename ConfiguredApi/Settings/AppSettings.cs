namespace ConfiguredApi.Settings;

public class AppSettings
{
    public string DefaultGreeting { get; set; } = "Greetings";
    public string WelcomeMessage { get; set; } = "Welcome";
    public bool EnableDebugMode { get; set; }
}