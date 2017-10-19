using System;
using System.Collections.Generic;
using MemoryManagementDemo.Engine;

namespace MemoryManagementDemo
{
    public class ForEachLoop : GameBehavior
    {
        protected override void OnAwake()
        {
        }

        protected override void OnStart()
        {
        }

        protected override void OnUpdate()
        {
            var list = new List<float>();

            //enumerator generates garbage
            foreach (var item in list)
            {              
            }

            //no garbage generated
            for (int i = 0; i < list.Count; i++)
            {              
            }
        }
    }
}
