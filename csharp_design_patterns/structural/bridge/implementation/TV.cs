namespace csharp_design_patterns.structural.bridge.implementation;

using System;

public class TV : IDevice
{
    private bool _on;
    private int _volume;

    public void PowerOn()
    {
        _on = true;
        Console.WriteLine("TV is now ON.");
    }

    public void PowerOff()
    {
        _on = false;
        Console.WriteLine("TV is now OFF.");
    }

    public void SetVolume(int percent)
    {
        _volume = percent;
        Console.WriteLine($"TV volume set to {_volume}%.");
    }

    public bool IsEnabled()
    {
        return _on;
    }
}

public class Radio : IDevice
{
    private bool _on;
    private int _volume;

    public void PowerOn()
    {
        _on = true;
        Console.WriteLine("Radio is now ON.");
    }

    public void PowerOff()
    {
        _on = false;
        Console.WriteLine("Radio is now OFF.");
    }

    public void SetVolume(int percent)
    {
        _volume = percent;
        Console.WriteLine($"Radio volume set to {_volume}%.");
    }

    public bool IsEnabled()
    {
        return _on;
    }
}
