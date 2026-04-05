namespace Facade;

public class Television
{
    public void TurnOn() => Console.WriteLine("  TV is ON");
    public void TurnOff() => Console.WriteLine("  TV is OFF");
    public void SetInput(string input) => Console.WriteLine($"  TV input set to {input}");
}
