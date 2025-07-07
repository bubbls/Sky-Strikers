using System;
using System.Collections.Generic;
using UnityEngine;
using moveen.example;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenRagdoll1 : MonoBehaviour, Startable
	{
		public MoveenStepper5 stepper;

		[ReadOnly]
		public bool isRagdoll;

		[NonSerialized]
		private List<RagdollState> bodyParts;

		[NonSerialized]
		private MoveenSkelWithBones[] cache1;

		[NonSerialized]
		private MoveenTransformCopier[] cache2;

		[NonSerialized]
		private Rigidbody[] cache3;

		[HideInInspector]
		public Rigidbody usedByStepper;

		[HideInInspector]
		public List<Joint> jointsToConnect;

		public void Start()
		{
		}

		public void startRagdoll()
		{
		}

		private void setKinematic(bool newValue)
		{
		}

		public void start()
		{
		}
	}
}
