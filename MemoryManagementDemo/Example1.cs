using System;
using MemoryManagementDemo.Engine;

namespace MemoryManagementDemo
{
    public class Example1 : GameBehavior
    {
        private readonly Vector3[] _bounds = new Vector3[4];
        private bool _wasDirectionEqual = false;
        private bool _wasMagnitudeEqual = false;

        protected override void OnAwake()
        {           
        }

        protected override void OnStart()
        {
        }

        protected override void OnUpdate()
        {
            _bounds[0] = new Vector3(0.0f, 1.0f, 0.0f);
            _bounds[1] = new Vector3(0.0f, -1.0f, 0.0f);
            _bounds[2] = new Vector3(1.0f, 0.0f, 0.0f);
            _bounds[3] = new Vector3(-1.0f, 0.0f, 0.0f);

            var directionA = new Vector3();
            directionA.X = _bounds[0].X - _bounds[1].X;
            directionA.Y = _bounds[0].Y - _bounds[1].Y;
            directionA.Z = _bounds[0].Z - _bounds[1].Z;

            var directionB = new Vector3();
            directionB.X = _bounds[2].X - _bounds[3].X;
            directionB.Y = _bounds[2].Y - _bounds[3].Y;
            directionB.Z = _bounds[2].Z - _bounds[3].Z;

            var magnitudeA = Math.Sqrt((_bounds[0].X * 2.0f) + (_bounds[0].Y * 2.0f) + (_bounds[0].Z * 2.0f));
            var magnitudeB = Math.Sqrt((_bounds[1].X * 2.0f) + (_bounds[1].Y * 2.0f) + (_bounds[1].Z * 2.0f));

            _wasDirectionEqual = directionA.Equals(directionB);
            _wasMagnitudeEqual = magnitudeA.Equals(magnitudeB);
        }
    }
}
