using System;
using Engine.Math;

namespace Engine
{
    class Program
    {
        static void Main()
        {
            var vector = new Vector2(1, 2);

            Console.Write(vector.Normalize().Normalize() + "\n");
        }
    }
}
