namespace Facade;

public class HomeTheaterFacade
{
    private readonly Television _tv;
    private readonly SoundSystem _sound;
    private readonly StreamingPlayer _player;
    private readonly Lights _lights;

    public HomeTheaterFacade(Television tv, SoundSystem sound, StreamingPlayer player, Lights lights)
    {
        _tv = tv;
        _sound = sound;
        _player = player;
        _lights = lights;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine($"Getting ready to watch \"{movie}\"...\n");
        _lights.Dim(15);
        _tv.TurnOn();
        _tv.SetInput("HDMI 1");
        _sound.TurnOn();
        _sound.SetSurroundMode();
        _sound.SetVolume(7);
        _player.TurnOn();
        _player.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("\nShutting down movie night...\n");
        _player.TurnOff();
        _sound.TurnOff();
        _tv.TurnOff();
        _lights.TurnOn();
    }
}
