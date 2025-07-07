using System;
using moveen.core;

namespace moveen.descs
{
	public class MoveenTransformConnector : MoveenSkelWithBones
	{
		[NonSerialized]
		private OriginRotPosP origin;

		public override void tickStructure(float dt)
		{
		}
	}
}
