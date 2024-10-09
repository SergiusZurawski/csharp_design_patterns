using csharp_design_patterns.creational.object_pool.implementation;

namespace csharp_design_patterns.creational.object_pool.client;



/*
  When to Use the Object Pool Pattern
Expensive Object Creation: When objects are resource-intensive to create (e.g., database connections, network sockets).
Performance Optimization: To improve performance by reusing objects rather than creating and destroying them frequently.
Resource Management: When managing a limited number of resources that can be shared among multiple clients.
High-Frequency Usage: In scenarios where objects are needed frequently and for short durations.

Components of the Object Pool Pattern
Reusable Object: The object that is expensive to create and can be reused.
Object Pool: Manages the pool of reusable objects, handling their allocation and deallocation.
Client: The code that uses the objects from the pool.

 
  
 */
public static class Example
{
    public static void ExecuteExample()
    {
        BulletPool bulletPool = new BulletPool(initialSize: 5, maxPoolSize: 10);

        // Simulate firing bullets
        for (int i = 0; i < 7; i++)
        {
            var bullet = bulletPool.GetBullet();
            if (bullet != null)
            {
                bullet.Fire(new Vector(i, i * 10), new Vector(1, 0));
            }
        }

        // Update bullets
        bulletPool.UpdateBullets();

        // Return bullets to pool (simulate bullets being destroyed)
        // In a real game, this would be triggered by collision detection or going off-screen
        foreach (var bullet in bulletPool._inUseBullets.ToArray())
        {
            bulletPool.ReturnBullet(bullet);
        }

        // Fire more bullets to see reuse
        for (int i = 0; i < 3; i++)
        {
            var bullet = bulletPool.GetBullet();
            if (bullet != null)
            {
                bullet.Fire(new Vector(i, i * 5), new Vector(0, 1));
            }
        }

        // Update bullets again
        bulletPool.UpdateBullets();
    }

}