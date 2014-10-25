namespace Engine
{
    class Vector3
    {
        public Vector3(float  x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        public float Magnitude()
        {
            return (float) System.Math.Sqrt(X*X + Y*Y + Z*Z);
        }

        public Vector3 Normalize()
        {
            return new Vector3(X/Magnitude(), Y/Magnitude(), Z/Magnitude());
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector3 operator *(Vector3 a, float b)
        {
            return new Vector3(a.X*b, a.Y*b, a.Z*b);
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }
    }
}
