using UnityEngine;

namespace moveen.core
{
	public abstract class OriginBase
	{
		public string name;

		public bool isStatic;

		public OriginBase()
		{
		}

		public virtual void tick()
		{
		}

		public abstract Matrix4x4 getMatrix();

		public abstract Vector3 getPos();

		public abstract Quaternion getRot();
	}
}
