using System;
using UnityEngine;
using UnityEngine.Serialization;
using moveen.core;
using moveen.descs;
using moveen.utils;

namespace moveen.example
{
	public class MoveControl2 : MonoBehaviour
	{
		[BindOrLocalWarning]
		[Header("   \"Top down\" view")]
		public FocusGrabber focusGrabber;

		[BindWarning]
		public MoveenStepper5 moveen;

		public Transform aimTarget;

		[BindWarning]
		public Camera cam;

		[Tooltip("Distance from body center to the ground")]
		public float height;

		[FormerlySerializedAs("walkLimit")]
		public float speed;

		[Tooltip("Target rotation angular speed")]
		public float bodyRotReactionSpeed;

		public float bodyRotLag;

		public bool localWasd;

		public float camAheadMul;

		[Tooltip("Speed multiplication when shift is pressed")]
		public float runSpeedMultiplier;

		[Tooltip("Adds additional jump force on the run")]
		public float runJumpTime;

		[Range(0f, 1f)]
		public float strafeSpeedMultiplyer;

		[Range(0f, 1f)]
		public float rearSpeedMultiplyer;

		[Tooltip("Useful for multipeds to be aligned to terrain inclination")]
		public bool inclineBodyToLegs;

		public float inclineBodyToLegsRatio;

		[Tooltip("If true, target position will switch sharply from point to point which produces more robotic like movements")]
		public bool quantCenter;

		[Tooltip("Quant size. Make it small for small models and big for big models. (Big for small models will make them walk by kind of grid. Small for big models will make quantCenter irrelevant)")]
		public float quantSize;

		[FormerlySerializedAs("camDif")]
		public Vector3 camPosition;

		public Vector3 camRotation;

		public float camApproachFactor;

		private Vector3 wantedCamera;

		private Rigidbody bodyRigid;

		private Vector3 oldCam;

		private float initialBodyLenHelp;

		[Header("Jump")]
		public float jumpPrepareHeightMul;

		public float jumpTargetHeightMul;

		public float jumpPrepareTime;

		public MotorBean jumpMotor;

		[ReadOnly]
		public bool jumpPreparing;

		[ReadOnly]
		public bool jumpInProgress;

		[ReadOnly]
		public float jumpStrengthCurTime;

		[NonSerialized]
		private readonly MotorBean previousVerticalMotor;

		private Vector3 upByLegs;

		[Header("Debug")]
		public bool debugMoveForward;

		public bool debugFreezeRotation;

		public bool debugRotateRight;

		private Quaternion quantedWantedRot;

		public void OnEnable()
		{
		}

		public void Start()
		{
		}

		public void FixedUpdate()
		{
		}

		private void calcUpByLegs()
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
