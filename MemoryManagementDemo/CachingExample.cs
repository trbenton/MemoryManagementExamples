using System;
using System.Collections.Generic;
using MemoryManagementDemo.Engine;

namespace MemoryManagementDemo
{
    public class CachingExample : GameBehavior
    {
        private readonly List<DateTime> _list = new List<DateTime>();

        protected override void OnAwake()
        {
        }

        protected override void OnStart()
        {
        }

        protected override void OnUpdate()
        {
            for (int i = 0; i < 100; i++)
            {
                _list.Add(new DateTime());
            }
            _list.Clear();
        }
    }
}
