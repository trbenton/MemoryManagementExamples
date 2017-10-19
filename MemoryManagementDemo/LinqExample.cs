using System;
using System.Collections.Generic;
using System.Linq;
using MemoryManagementDemo.Engine;

namespace MemoryManagementDemo
{
    public class LinqExample : GameBehavior
    {
        protected override void OnAwake()
        {
        }

        protected override void OnStart()
        {
        }

        protected override void OnUpdate()
        {
            var list = new  List<int> { 1, 2, 3, 4, 5 };

            //generates garbage
            int linqMin = list.Min(i => i);


            //no garbage generated
            int simpleMin = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                simpleMin = Math.Min(simpleMin, list[i]);
            }
        }
    }
}
