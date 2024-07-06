namespace csharp_design_patterns.structural.adapter.implementation;

public class AudioPlayer : IMediaPlayer
{
    private MediaAdapter _mediaAdapter;

    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Playing mp3 file. Name: " + fileName);
        }
        else if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase) || audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            _mediaAdapter = new MediaAdapter(audioType);
            _mediaAdapter.Play(audioType, fileName);
        }
        else
        {
            Console.WriteLine("Invalid media. " + audioType + " format not supported");
        }
    }
}
