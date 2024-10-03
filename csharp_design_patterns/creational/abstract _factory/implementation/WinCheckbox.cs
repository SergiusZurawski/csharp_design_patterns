namespace csharp_design_patterns.creational.abstract__factory.implementation;

// WinCheckbox.cs
public class WinCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in Windows style.");
    }
}
