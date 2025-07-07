using UnityEngine;

namespace moveen.core
{
	public class Bone
	{
		public float r;

		public OriginBase origin;

		public Transform attachedGeometry;

		public Vector3 deltaPos;

		public Quaternion deltaRot;

		public void copy()
		{
		}

		public void copy(Transform other, float progress)
		{
		}

		public Bone(OriginBase origin, float r)
		{
		}
	}
}
