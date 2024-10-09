namespace csharp_design_patterns.creational.prototype.implementation;

public class Circle : IShape
{
    public int Radius { get; set; }

    public Circle(int radius)
    {
        Radius = radius;
    }

    // Clone method
    public IShape Clone()
    {
        return new Circle(this.Radius);
    }

    public void GetInfo()
    {
        Console.WriteLine($"This is a circle with radius {Radius}.");
    }
}