namespace csharp_design_patterns.structural.facade;

public class Amplifier
{
    public void On() => Console.WriteLine("Amplifier is On.");
    public void SetVolume(int level) => Console.WriteLine($"Amplifier volume set to {level}.");
    public void Off() => Console.WriteLine("Amplifier is Off.");
}

public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD Player is On.");
    public void Play(string movie) => Console.WriteLine($"Playing movie: {movie}");
    public void Stop() => Console.WriteLine("DVD Player stopped.");
    public void Off() => Console.WriteLine("DVD Player is Off.");
}

public class Projector
{
    public void On() => Console.WriteLine("Projector is On.");
    public void SetInput(string input) => Console.WriteLine($"Projector input set to {input}.");
    public void Off() => Console.WriteLine("Projector is Off.");
}