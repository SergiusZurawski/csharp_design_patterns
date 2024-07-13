namespace csharp_design_patterns.structural.facade.implementation;

public class HomeTheaterFacade
{
    private Amplifier _amplifier;
    private DVDPlayer _dvdPlayer;
    private Projector _projector;

    public HomeTheaterFacade(Amplifier amplifier, DVDPlayer dvdPlayer, Projector projector)
    {
        _amplifier = amplifier;
        _dvdPlayer = dvdPlayer;
        _projector = projector;
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Get ready to watch a movie...");
        _amplifier.On();
        _amplifier.SetVolume(5);
        _dvdPlayer.On();
        _projector.On();
        _projector.SetInput("DVD");
        _dvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Shutting down the movie theater...");
        _dvdPlayer.Stop();
        _dvdPlayer.Off();
        _projector.Off();
        _amplifier.Off();
    }
}
