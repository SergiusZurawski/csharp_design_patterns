namespace csharp_design_patterns.creational.object_pool.implementation;

using System.Collections.Generic;

public class BulletPool
{
    private readonly List<Bullet> _availableBullets;
    public readonly List<Bullet> _inUseBullets;
    private readonly int _maxPoolSize;

    public BulletPool(int initialSize, int maxPoolSize)
    {
        _maxPoolSize = maxPoolSize;
        _availableBullets = new List<Bullet>(initialSize);
        _inUseBullets = new List<Bullet>();

        // Initialize the pool with inactive bullets
        for (int i = 0; i < initialSize; i++)
        {
            _availableBullets.Add(new Bullet());
        }
    }

    public Bullet GetBullet()
    {
        Bullet bullet;

        if (_availableBullets.Count > 0)
        {
            // Reuse an available bullet
            bullet = _availableBullets[0];
            _availableBullets.RemoveAt(0);
        }
        else if (_inUseBullets.Count + _availableBullets.Count < _maxPoolSize)
        {
            // Create a new bullet if pool is not at max capacity
            bullet = new Bullet();
        }
        else
        {
            // Pool has reached max capacity
            Console.WriteLine("No bullets available!");
            return null;
        }

        _inUseBullets.Add(bullet);
        return bullet;
    }

    public void ReturnBullet(Bullet bullet)
    {
        bullet.Destroy();
        _inUseBullets.Remove(bullet);
        _availableBullets.Add(bullet);
    }

    public void UpdateBullets()
    {
        foreach (var bullet in _inUseBullets.ToArray()) // Use ToArray to avoid modification during iteration
        {
            bullet.Update();
            // For demo purposes, let's assume bullets become inactive after one update
            if (!bullet.IsActive)
            {
                ReturnBullet(bullet);
            }
        }
    }
}

