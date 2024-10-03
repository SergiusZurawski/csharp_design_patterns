namespace csharp_design_patterns.creational.abstract__factory;

// IGUIFactory.cs
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

