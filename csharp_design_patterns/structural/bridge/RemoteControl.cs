namespace csharp_design_patterns.structural.bridge;

public abstract class RemoteControl
{
    protected IDevice _device;

    protected RemoteControl(IDevice device)
    {
        _device = device;
    }

    public abstract void TogglePower();
    public abstract void VolumeDown();
    public abstract void VolumeUp();
}
