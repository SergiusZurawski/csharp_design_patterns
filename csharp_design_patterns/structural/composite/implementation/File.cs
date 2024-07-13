namespace csharp_design_patterns.structural.composite.implementation;

public class File : IFileSystemItem
{
    private string _name;

    public File(string name)
    {
        _name = name;
    }

    public void Display(int depth)
    {
        Console.WriteLine(new String('-', depth) + _name);
    }
}
