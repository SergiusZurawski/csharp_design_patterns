namespace csharp_design_patterns.structural.adapter.client;

public interface IAdvancedMediaPlayer
{
    void PlayVlc(string fileName);
    void PlayMp4(string fileName);
}