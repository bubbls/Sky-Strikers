using UnityEngine;

namespace moveen.descs
{
	public class MoveenSkelBezierPrefab : MoveenSkelBezier
	{
		public GameObject prefab;

		public Vector3 posDisp;

		public Vector3 rotDisp;

		public Vector3 scale;

		private Quaternion rotDispQ;

		public override void updateData()
		{
		}

		public override void tick(float dt)
		{
		}

		public virtual Vector3 posChange(Vector3 basisPos, Quaternion basisRot, int iU)
		{
			return default(Vector3);
		}

		public virtual Quaternion rotChange(Quaternion rot, int iU)
		{
			return default(Quaternion);
		}

		public virtual Vector3 scaleChange(int iU)
		{
			return default(Vector3);
		}
	}
}
