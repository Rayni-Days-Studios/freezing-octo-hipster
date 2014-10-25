using Engine.Math;

namespace Engine.Components
{
    class Transform : Component
    {
        public Transform(Vector3 position, Vector3 rotation, Vector3 scale) : base("Transform")
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        public Transform(Vector2 position, Vector2 rotation, Vector2 scale) : base("Transform")
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }

        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": Position: " + Position + ", Rotation: " + Rotation + ", Scale: " + Scale;
        }
    }
}
