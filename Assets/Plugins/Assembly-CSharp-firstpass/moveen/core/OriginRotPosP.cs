using UnityEngine;
using moveen.utils;

namespace moveen.core
{
	public class OriginRotPosP : OriginBase
	{
		public P<Quaternion> rot;

		public P<Vector3> pos;

		private bool isDirty;

		private Matrix4x4 matrix;

		public OriginRotPosP()
		{
		}

		public OriginRotPosP(P<Quaternion> rot, P<Vector3> pos)
		{
		}

		public override void tick()
		{
		}

		public override Matrix4x4 getMatrix()
		{
			return default(Matrix4x4);
		}

		public override Vector3 getPos()
		{
			return default(Vector3);
		}

		public override Quaternion getRot()
		{
			return default(Quaternion);
		}
	}
}
