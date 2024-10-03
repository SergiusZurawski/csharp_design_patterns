namespace csharp_design_patterns.creational.abstract__factory.implementation;

// MacCheckbox.cs
public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Rendering a checkbox in macOS style.");
    }
}
