using csharp_design_patterns.creational.object_pool.implementation;

namespace csharp_design_patterns.creational.object_pool;
using csharp_design_patterns.creational.object_pool;

public class Bullet
{
    public bool IsActive { get; set; }

    public void Fire(Vector position, Vector direction)
    {
        IsActive = true;
        // Initialize bullet position and direction
        Console.WriteLine($"Bullet fired at position {position} with direction {direction}.");
    }

    public void Update()
    {
        if (IsActive)
        {
            // Update bullet position based on direction
            Console.WriteLine("Bullet is updating its position.");
        }
    }

    public void Destroy()
    {
        IsActive = false;
        // Reset bullet state
        Console.WriteLine("Bullet has been destroyed and returned to pool.");
    }
}
