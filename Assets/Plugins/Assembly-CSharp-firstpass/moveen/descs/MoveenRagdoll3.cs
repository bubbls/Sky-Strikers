using System;
using UnityEngine;
using moveen.example;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenRagdoll3 : MonoBehaviour, Startable
	{
		[BindWarning]
		public MoveenStepper5 stepper;

		[Tooltip("This joint can't be active when Moveen is working. So it will be enabled when the leg is going ragdoll")]
		[BindWarning]
		public Joint bodyJoint;

		[BindOrLocalWarning]
		public MoveenStep2 step;

		[Tooltip("Skel, which should be disabled when going to ragdoll")]
		[BindOrLocalWarning]
		public MoveenSkelWithBones bones;

		[Tooltip("Switcher, which does the actual work switching to the ragdoll")]
		[BindOrLocalWarning]
		public MoveenRagdollSwitch switcher;

		[Tooltip("Mixer script mixes last ragdolled animation with newly active one")]
		[BindOrLocalWarning]
		public MoveenMix mixer;

		public bool isRagdoll;

		[NonSerialized]
		private bool isRagdollOld;

		public float activationTime;

		[NonSerialized]
		public float currentActivationTime;

		public void Start()
		{
		}

		private void Update()
		{
		}

		public void start()
		{
		}
	}
}
