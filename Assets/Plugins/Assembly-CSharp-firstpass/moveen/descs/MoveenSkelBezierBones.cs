using System.Collections.Generic;
using UnityEngine;

namespace moveen.descs
{
	public class MoveenSkelBezierBones : MoveenSkelBezier
	{
		public List<Vector3> bonesDeltaPos;

		public List<Quaternion> bonesDeltaRot;

		public List<int> stepNumbers;

		public override void updateData()
		{
		}

		public override void tick(float dt)
		{
		}

		public void OnTransformChildrenChanged()
		{
		}

		public void updateDeltas()
		{
		}

		public void useDeltas()
		{
		}
	}
}
