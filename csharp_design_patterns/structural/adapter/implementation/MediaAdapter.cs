using csharp_design_patterns.structural.adapter.client;

namespace csharp_design_patterns.structural.adapter.implementation;

public class MediaAdapter : IMediaPlayer
{
    private IAdvancedMediaPlayer _advancedMediaPlayer;

    public MediaAdapter(string audioType)
    {
        if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
        {
            _advancedMediaPlayer = new VlcPlayer();
        }
        else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            _advancedMediaPlayer = new Mp4Player();
        }
    }

    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("vlc", StringComparison.OrdinalIgnoreCase))
        {
            _advancedMediaPlayer.PlayVlc(fileName);
        }
        else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
        {
            _advancedMediaPlayer.PlayMp4(fileName);
        }
    }
}
