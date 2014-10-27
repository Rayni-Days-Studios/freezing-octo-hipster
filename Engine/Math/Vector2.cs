namespace Engine.Math
{
    class Vector2
    {

        #region Constructors

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        #endregion

        #region Getters and Setters

        public float X { get; set; }
        public float Y { get; set; }

        #endregion

        #region Math Functions

        public float Magnitude()
        {
            return (float)System.Math.Sqrt(X * X + Y * Y);
        }

        public Vector2 Normalize()
        {
            return new Vector2(X / Magnitude(), Y / Magnitude());
        }

        #endregion

        #region Operator Overloads

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

        #endregion

        #region Default Overloads

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }

        #endregion
    }
}
