using csharp_design_patterns.structural.adapter.implementation;

namespace csharp_design_patterns.structural.adapter.client;

public static class Example
{
    public static void ExecuteExample()
    {
        AudioPlayer audioPlayer = new AudioPlayer();

        audioPlayer.Play("mp3", "song.mp3");
        audioPlayer.Play("mp4", "movie.mp4");
        audioPlayer.Play("vlc", "video.vlc");
        audioPlayer.Play("avi", "myMovie.avi");
    }

}