using System;
using UnityEngine;
using moveen.core;
using moveen.descs;
using moveen.utils;

namespace moveen.example
{
	public class MoveControl3 : MonoBehaviour
	{
		[BindWarning]
		[Header("   For NPC only")]
		public MoveenStepper5 moveen;

		public Transform aimTarget;

		[Tooltip("Distance from body center to the ground")]
		public float height;

		public float speed;

		[Tooltip("Target rotation angular speed")]
		public float bodyRotReactionSpeed;

		[Tooltip("Speed multiplication whe shift is pressed")]
		public float runSpeedMultiplier;

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

		private Rigidbody bodyRigid;

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

		public Quaternion chassisRot;

		public Vector3 moveDir;

		public Vector3 aimPos;

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
