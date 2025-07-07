using UnityEngine;
using moveen.core;

namespace moveen.descs
{
	public class MoveenSkelRotHydraulic : MoveenSkelWithBones
	{
		public float r1;

		public float r2;

		[CustomSkelControl]
		public Vector3 normalRel;

		public JunctionSimpleSpider rotationJoint;

		public override void updateData()
		{
		}

		public override void tickStructure(float dt)
		{
		}
	}
}
