namespace csharp_design_patterns.structural.bridge;

public interface IDevice
{
    void PowerOn();
    void PowerOff();
    void SetVolume(int percent);
    bool IsEnabled();
}
