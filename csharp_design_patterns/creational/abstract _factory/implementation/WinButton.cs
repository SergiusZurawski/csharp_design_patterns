namespace csharp_design_patterns.creational.abstract__factory.implementation;

public class WinButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in Windows style.");
    }
}
