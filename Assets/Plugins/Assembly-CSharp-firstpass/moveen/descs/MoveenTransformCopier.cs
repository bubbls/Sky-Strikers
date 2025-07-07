using UnityEngine;
using moveen.utils;

namespace moveen.descs
{
	[ExecuteInEditMode]
	public class MoveenTransformCopier : OrderedMonoBehaviour
	{
		[HideInInspector]
		public Vector3 deltaPos;

		[HideInInspector]
		public Quaternion deltaRot;

		public Transform target;

		public float transition;

		public override void tick(float dt)
		{
		}

		private void copyTransforms()
		{
		}

		private void updateDeltas()
		{
		}
	}
}
