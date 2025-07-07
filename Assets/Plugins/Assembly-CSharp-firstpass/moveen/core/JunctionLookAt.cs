using UnityEngine;
using moveen.utils;

namespace moveen.core
{
	public class JunctionLookAt : JunctionBase
	{
		public Vector3 YRel;

		public P<Vector3> YAbs;

		public Quaternion resultRot;

		public override void calcAbs(float dt, Vector3 pos, Quaternion rot)
		{
		}

		public override void tick(float dt)
		{
		}
	}
}
