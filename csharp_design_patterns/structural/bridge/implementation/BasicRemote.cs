namespace csharp_design_patterns.structural.bridge.implementation;

using System;

public class BasicRemote : RemoteControl
{
    public BasicRemote(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        if (_device.IsEnabled())
        {
            _device.PowerOff();
        }
        else
        {
            _device.PowerOn();
        }
    }

    public override void VolumeDown()
    {
        Console.WriteLine("Basic Remote: Volume down");
        _device.SetVolume(10); // Assume we decrease volume by a fixed amount
    }

    public override void VolumeUp()
    {
        Console.WriteLine("Basic Remote: Volume up");
        _device.SetVolume(20); // Assume we increase volume by a fixed amount
    }
}

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        if (_device.IsEnabled())
        {
            _device.PowerOff();
        }
        else
        {
            _device.PowerOn();
        }
    }

    public override void VolumeDown()
    {
        Console.WriteLine("Advanced Remote: Volume down");
        _device.SetVolume(5); // Assume we decrease volume by a fixed amount
    }

    public override void VolumeUp()
    {
        Console.WriteLine("Advanced Remote: Volume up");
        _device.SetVolume(30); // Assume we increase volume by a fixed amount
    }

    public void Mute()
    {
        Console.WriteLine("Advanced Remote: Mute");
        _device.SetVolume(0); // Mute the device
    }
}
