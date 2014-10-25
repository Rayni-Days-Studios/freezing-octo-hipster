using System;
using Engine.Components;
using Engine.GameObject;

namespace Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new GameObject.GameObject(new Transform(new Vector3(1, 2, 3), new Vector3(0, 0, 0), new Vector3(1, 1, 1)));
            Console.Write(obj.GetComponent());
        }
    }
}
