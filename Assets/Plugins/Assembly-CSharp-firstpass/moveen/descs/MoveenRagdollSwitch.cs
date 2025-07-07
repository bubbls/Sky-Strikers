using System;
using System.Collections.Generic;
using UnityEngine;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenRagdollSwitch : OrderedMonoBehaviour
	{
		public bool isRagdoll;

		[NonSerialized]
		private bool isRagdollOld;

		[Tooltip("Must be used in conjuction with MoveenMix")]
		public bool canRiseFromRagdoll;

		private List<RagdollState> bodyParts;

		public void Start()
		{
		}

		public void startRagdoll()
		{
		}

		public void stopRagdoll()
		{
		}

		private void setKinematic(bool newValue)
		{
		}

		public override void tick(float dt)
		{
		}
	}
}
