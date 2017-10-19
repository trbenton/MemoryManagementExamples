using System;
using System.Collections.Generic;
using MemoryManagementDemo.Engine;

namespace MemoryManagementDemo
{
    public class HeapVsStack : GameBehavior
    {
        protected override void OnAwake()
        {           
        }

        protected override void OnStart()
        {
        }

        protected override void OnUpdate()
        {
            //heap allocation
            var list = new List<DateTime>();

            for (int i = 0; i < 100; i++)
            {
                //stack allocation
                list.Add(new DateTime());
            }
        }
    }
}
