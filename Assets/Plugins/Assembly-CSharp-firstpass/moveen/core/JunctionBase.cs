using UnityEngine;
using moveen.utils;

namespace moveen.core
{
	public abstract class JunctionBase : Tickable
	{
		public P<Vector3> basisAbs;

		public P<Vector3> resultAbs;

		public P<Vector3> targetAbs;

		public P<Vector3> normalAbs;

		public abstract void tick(float dt);

		public virtual void calcAbs(float dt, Vector3 pos, Quaternion rot)
		{
		}

		public virtual void reset()
		{
		}
	}
}
