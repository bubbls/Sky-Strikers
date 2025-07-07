using System;
using UnityEngine;
using UnityEngine.Serialization;
using moveen.core;

namespace moveen.descs
{
	public class MoveenSkelLimb1 : MoveenSkelWithBones
	{
		[CustomSkelControl]
		public float r1;

		[CustomSkelControl]
		public float r2;

		[NonSerialized]
		[CustomSkelResult]
		public Vector3 elbow;

		[FormerlySerializedAs("rotationJoint")]
		[CustomSkelControl]
		public JunctionSimpleSpider rotJoint;

		private readonly JunctionElbow elbowJoint;

		public float footPlatformHeight;

		public override void updateData()
		{
		}

		public override void tickStructure(float dt)
		{
		}

		public override bool canBeSolved()
		{
			return false;
		}
	}
}
