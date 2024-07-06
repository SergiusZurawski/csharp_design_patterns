using csharp_design_patterns.structural.adapter.client;

namespace csharp_design_patterns.structural.adapter.implementation;

public class VlcPlayer : IAdvancedMediaPlayer
{
    public void PlayVlc(string fileName)
    {
        Console.WriteLine("Playing vlc file. Name: " + fileName);
    }

    public void PlayMp4(string fileName)
    {
        // Do nothing
    }
}

public class Mp4Player : IAdvancedMediaPlayer
{
    public void PlayVlc(string fileName)
    {
        // Do nothing
    }

    public void PlayMp4(string fileName)
    {
        Console.WriteLine("Playing mp4 file. Name: " + fileName);
    }
}
