using System;
using System.Collections.Generic;
using UnityEngine;

namespace moveen.descs
{
	public class MoveenSkelBezier : MoveenSkelBase
	{
		public float radius1;

		public float radius2;

		public int stepsCount;

		[Tooltip("Orientation not connected to origins. Can be faster")]
		public bool simpleOrientation;

		[NonSerialized]
		public List<Vector3> poss;

		[NonSerialized]
		public List<Quaternion> rots;

		public override void updateData()
		{
		}

		public override void tick(float dt)
		{
		}

		public void fillOrigins(Vector3 xA1, float ar, Quaternion fromRot, Vector3 xB1, float br, Quaternion toRot, List<Vector3> poss, List<Quaternion> rots)
		{
		}

		public void OnDrawGizmos()
		{
		}

		private static void paintOrigin(Vector3 last, Quaternion lastRot, float size = 0.1f)
		{
		}
	}
}
