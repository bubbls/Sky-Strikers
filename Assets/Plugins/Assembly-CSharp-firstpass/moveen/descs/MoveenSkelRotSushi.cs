using UnityEngine;
using UnityEngine.Serialization;
using moveen.core;

namespace moveen.descs
{
	public class MoveenSkelRotSushi : MoveenSkelWithBones
	{
		[CustomSkelControl]
		public float r1;

		public float r2;

		[CustomSkelResult]
		public Vector3 elbowAbs;

		[FormerlySerializedAs("rotationJoint")]
		[CustomSkelControl]
		public JunctionSimpleSpider rotJoint;

		private JunctionSushi elbowJoint;

		public override void updateData()
		{
		}

		public override void tickStructure(float dt)
		{
		}
	}
}
