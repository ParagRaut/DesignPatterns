namespace Facade;

public class SoundSystem
{
    public void TurnOn() => Console.WriteLine("  Sound system is ON");
    public void TurnOff() => Console.WriteLine("  Sound system is OFF");
    public void SetVolume(int level) => Console.WriteLine($"  Volume set to {level}");
    public void SetSurroundMode() => Console.WriteLine("  Surround sound enabled");
}
