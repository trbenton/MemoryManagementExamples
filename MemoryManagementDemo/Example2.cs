using MemoryManagementDemo.Engine;
using MemoryManagementDemo.Game.Object;

namespace MemoryManagementDemo
{
    public class Example2 : GameBehavior
    {
        protected override void OnAwake()
        {       
        }

        protected override void OnStart()
        {
        }

        protected override void OnUpdate()
        {
            for (int i = 0; i < 25; i++)
            {
                var proj = new Projectile();
                proj.Fire();
            }
        }
    }
}
