using System.Collections.Generic;

namespace MemoryManagementDemo.Game.Object
{
    public class Projectile
    {
        private const int MaxPoolSize = 1000;
        private static readonly Stack<Projectile> Projectiles = new Stack<Projectile>();

        public void Fire()
        {
            
        }

        public static Projectile MemAlloc()
        {
            //if we have a projectile, return it. Otherwise we allocate a new one
            if (Projectiles.Count > 0)
                return Projectiles.Pop();
            return new Projectile();
        }

        public static void Free(Projectile obj)
        {
            //if we have room for the projectile, add it to the stack. If we have no room, allow it to be garbage collected.
            if (Projectiles.Count < MaxPoolSize)
            {
                Projectiles.Push(obj);
            }
        }
    }
}
