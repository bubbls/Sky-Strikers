using System;
using UnityEngine;
using UnityEngine.Serialization;
using moveen.core;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenSkelLimb2 : MoveenSkelWithBones
	{
		[CustomSkelControl]
		public float rA;

		[CustomSkelControl]
		public float rB;

		[CustomSkelControl]
		public float rC;

		[CustomSkelControl]
		public float r1;

		[CustomSkelControl]
		public float r2;

		[Range(0f, 1f)]
		public float styleRatio;

		public bool style;

		public bool z;

		public P<Vector3> elbowAbs1;

		public P<Vector3> elbowAbs2;

		[NonSerialized]
		[CustomSkelResult]
		public Vector3 elbow1;

		[NonSerialized]
		[CustomSkelResult]
		public Vector3 elbow2;

		public float footPlatformHeight;

		[FormerlySerializedAs("rotationJoint")]
		[CustomSkelControl]
		public JunctionSimpleSpider rotJoint;

		public readonly JunctionElbow invisibleElbowJoint;

		public readonly JunctionElbow visibleElbowJoint;

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
