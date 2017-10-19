using System.Runtime.InteropServices;

namespace MemoryManagementDemo.Engine
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override bool Equals(object obj) //boxing the struct into an object on the heap
        {
            if (obj is Vector3)
            {
                var other = (Vector3) obj; //unboxing the object on the heap into a struct on the stack
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode * 31) ^ Y.GetHashCode();
                hashCode = (hashCode * 31) ^ Z.GetHashCode();
                return hashCode;
            }
        }
    }
}
