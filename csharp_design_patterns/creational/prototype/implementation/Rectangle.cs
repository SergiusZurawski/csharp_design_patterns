namespace csharp_design_patterns.creational.prototype.implementation;

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    // Clone method
    public IShape Clone()
    {
        return new Rectangle(this.Width, this.Height);
    }

    public void GetInfo()
    {
        Console.WriteLine($"This is a rectangle with width {Width} and height {Height}.");
    }
}
