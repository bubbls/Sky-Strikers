using System.Collections.Generic;
using UnityEngine;
using moveen.utils;

namespace moveen.core
{
	public class OriginGlobalVectorP : OriginBase
	{
		public bool forcedRotationEnabled;

		public Quaternion forcedRotation;

		public P<Vector3> O;

		public P<Vector3> X;

		public P<Vector3> Y;

		public bool xz;

		public bool xIsNormalizedRay;

		public bool yIsNormalizedRay;

		public Vector3 x;

		public Vector3 y;

		public Vector3 z;

		public bool invertY;

		private Vector3 pos;

		private Quaternion rot;

		public OriginGlobalVectorP()
		{
		}

		public OriginGlobalVectorP(P<Vector3> o, P<Vector3> x, P<Vector3> y)
		{
		}

		public OriginGlobalVectorP(P<Vector3> o, P<Vector3> x, bool xIsNormalizedRay, P<Vector3> y, bool yIsNormalizedRay)
		{
		}

		public OriginGlobalVectorP setXz()
		{
			return null;
		}

		public OriginGlobalVectorP setInvertY(bool invertY)
		{
			return null;
		}

		public OriginGlobalVectorP(List<P<Vector3>> oxy)
		{
		}

		public Vector3 toLocal(Vector3 abs)
		{
			return default(Vector3);
		}

		public Vector3 toGlobal(Vector3 local)
		{
			return default(Vector3);
		}

		private Quaternion getRotation()
		{
			return default(Quaternion);
		}

		public Vector3 getMidPosition()
		{
			return default(Vector3);
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
