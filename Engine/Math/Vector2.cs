namespace Engine.Math
{
    class Vector2
    {
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public float Magnitude()
        {
            return (float)System.Math.Sqrt(X * X + Y * Y);
        }

        public Vector2 Normalize()
        {
            return new Vector2(X / Magnitude(), Y / Magnitude());
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2 operator -(Vector2 vector)
        {
            return new Vector2(-vector.X, -vector.Y);
        }

        public static Vector2 operator *(Vector2 a, float b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
