namespace csharp_design_patterns.creational.object_pool.implementation;

public struct Vector
{
    public float X { get; set; }
    public float Y { get; set; }

    public Vector(float x, float y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
