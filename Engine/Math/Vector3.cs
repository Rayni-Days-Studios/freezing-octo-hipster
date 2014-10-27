namespace Engine.Math
{
    class Vector3
    {
        #region Constructors

        public Vector3(float  x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion

        #region Static Members

        public static Vector3 Zero = new Vector3(0, 0, 0);
        public static Vector3 Up = new Vector3(0, 1, 0);
        public static Vector3 Down = -Up;
        public static Vector3 Right = new Vector3(1, 0, 0);
        public static Vector3 Left = -Right;
        public static Vector3 Forward = new Vector3(0, 0, 1);
        public static Vector3 Back = -Forward;

        #endregion

        #region Getters and Setters

        public float X { get; set; }

        public float Y { get; set; }

        public float Z { get; set; }

        #endregion

        #region Math Methods

        public float Magnitude()
        {
            return (float) System.Math.Sqrt(X*X + Y*Y + Z*Z);
        }

        public Vector3 Normalize()
        {
            return new Vector3(X/Magnitude(), Y/Magnitude(), Z/Magnitude());
        }

        #endregion

        #region Operator Overloads

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Vector3 operator -(Vector3 vector)
        {
            return new Vector3(-vector.X, -vector.Y, -vector.Z);
        }

        public static Vector3 operator *(Vector3 a, float b)
        {
            return new Vector3(a.X*b, a.Y*b, a.Z*b);
        }

        #endregion

        #region Default Overloads

        public override string ToString()
        {
            return "(" + X + ", " + Y + ", " + Z + ")";
        }

        #endregion
    }
}
