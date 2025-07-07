using System;
using UnityEngine;
using moveen.example;
using moveen.utils;

namespace moveen.descs
{
	public class MoveenRagdoll2 : MonoBehaviour, Startable
	{
		[BindWarning]
		public MoveenStepper5 stepper;

		[Tooltip("This joint can't be active when Moveen is working. So it will be enabled when the leg is going ragdoll")]
		[BindWarning]
		public Joint bodyJoint;

		[Tooltip("Skel, which should be disabled when going to ragdoll")]
		[BindOrLocalWarning]
		public MoveenSkelWithBones bones;

		[BindOrLocalWarning]
		[Tooltip("Switcher, which does the actual work switching to the ragdoll")]
		public MoveenRagdollSwitch switcher;

		[Tooltip("Repulsion force to affect both leg and body")]
		public float repulsion;

		public bool isRagdoll;

		[NonSerialized]
		private bool isRagdollOld;

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
