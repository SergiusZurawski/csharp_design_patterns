namespace csharp_design_patterns.creational.abstract__factory.implementation;

// WinFactory.cs
public class WinFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}
