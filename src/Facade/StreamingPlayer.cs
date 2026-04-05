namespace Facade;

public class StreamingPlayer
{
    public void TurnOn() => Console.WriteLine("  Streaming player is ON");
    public void TurnOff() => Console.WriteLine("  Streaming player is OFF");
    public void Play(string movie) => Console.WriteLine($"  Now playing: {movie}");
    public void Pause() => Console.WriteLine("  Playback paused");
}
