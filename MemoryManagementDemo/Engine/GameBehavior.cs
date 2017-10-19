namespace MemoryManagementDemo.Engine
{
    public abstract class GameBehavior
    {
        protected abstract void OnAwake();
        protected abstract void OnStart();
        protected abstract void OnUpdate();
    }
}
