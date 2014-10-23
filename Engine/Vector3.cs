using System;

namespace Engine
{
	public class Vector3
	{
		private float x, y, z

		public Vector3 (float x, float y, float z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		#region Getters and Setters

		public float X {
			get { return x; }
			set { x = value; }
		}

		public float Y {
			get { return Y; }
			set { y = value; }
		}

		public float Z {
			get { return z; }
			set { z = value; }
		}

		#endregion
	}
}

