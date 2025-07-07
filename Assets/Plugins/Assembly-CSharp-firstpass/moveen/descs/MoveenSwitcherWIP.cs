using UnityEngine;

namespace moveen.descs
{
	public class MoveenSwitcherWIP : MonoBehaviour
	{
		public MoveenMix animationToRagdoll;

		public MoveenMix allToStepper;

		public MoveenRagdollSwitch ragdoller;

		public MoveenStepper5 stepper;

		public Animator animator;

		public Transform geometry;

		public Vector3 animationDisplacement;

		public static int Idle_simple;

		public static int Simple_jump;

		public static int Revive;

		public float reviving;

		private MoveenSkelWithBones[] cache1;

		private MoveenTransformCopier[] cache2;

		private void Update()
		{
		}

		public void revive()
		{
		}

		public void die()
		{
		}

		public void beginSimpleJump()
		{
		}

		private void Awake()
		{
		}

		public void turnOnStepper()
		{
		}

		public bool stepperIsTurnedOn()
		{
			return false;
		}

		public void turnOffStepper()
		{
		}
	}
}
