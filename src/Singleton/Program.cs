using Singleton;

// Both references point to the exact same instance
var config1 = AppConfiguration.Instance;
var config2 = AppConfiguration.Instance;

Console.WriteLine($"Same instance? {ReferenceEquals(config1, config2)}");

config1.PrintAll();

// Change a setting via one reference...
config1.Set("Environment", "Production");

// ...and it's visible through the other
Console.WriteLine($"\nEnvironment via config2: {config2.Get("Environment")}");
