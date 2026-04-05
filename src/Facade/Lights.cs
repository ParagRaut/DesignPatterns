namespace Facade;

public class Lights
{
    public void Dim(int level) => Console.WriteLine($"  Lights dimmed to {level}%");
    public void TurnOn() => Console.WriteLine("  Lights are ON (full brightness)");
}
