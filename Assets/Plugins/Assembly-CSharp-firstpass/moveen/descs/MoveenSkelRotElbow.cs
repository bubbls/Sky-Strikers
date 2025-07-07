using UnityEngine;
using moveen.core;

namespace moveen.descs
{
	public class MoveenSkelRotElbow : MoveenSkelWithBones
	{
		[CustomSkelControl]
		public Vector3 normalRel;

		[CustomSkelControl]
		public float r1;

		[CustomSkelControl]
		public float r2;

		[CustomSkelResult]
		public Vector3 elbowAbs;

		private JunctionSimpleSpider rotationJoint;

		private JunctionElbow elbowJoint;

		public override void updateData()
		{
		}

		public override void tickStructure(float dt)
		{
		}
	}
}
