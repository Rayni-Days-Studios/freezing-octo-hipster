using System;
using Engine.Math;

namespace Engine
{
    class Program
    {
        static void Main()
        {
            var vector = new Vector2(300, 360);

            Console.Write(vector.Normalize() + "\n");
        }
    }
}
