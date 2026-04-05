namespace Singleton;

public sealed class AppConfiguration
{
    private static readonly Lazy<AppConfiguration> _instance = new(() => new AppConfiguration());

    private readonly Dictionary<string, string> _settings = new();

    private AppConfiguration()
    {
        // Simulate loading defaults
        _settings["AppName"] = "DesignPatterns";
        _settings["Version"] = "1.0.0";
        _settings["Environment"] = "Development";
    }

    public static AppConfiguration Instance => _instance.Value;

    public string Get(string key) =>
        _settings.TryGetValue(key, out var value) ? value : throw new KeyNotFoundException($"Setting '{key}' not found.");

    public void Set(string key, string value) => _settings[key] = value;

    public void PrintAll()
    {
        Console.WriteLine("--- App Configuration ---");
        foreach (var (key, value) in _settings)
        {
            Console.WriteLine($"  {key}: {value}");
        }
    }
}
