namespace csharp_design_patterns.creational.abstract__factory.implementation;

public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Rendering a button in macOS style.");
    }
}
