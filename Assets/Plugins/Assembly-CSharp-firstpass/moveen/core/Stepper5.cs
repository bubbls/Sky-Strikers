using System;
using System.Collections.Generic;
using UnityEngine;
using moveen.descs;
using moveen.utils;

namespace moveen.core
{
	[Serializable]
	public class Stepper5
	{
		[Tooltip("Logical right leg to calculate gait (even for multipeds)")]
		public int leadingLegRight;

		[Tooltip("Logical left leg to calculate gait (even for multipeds)")]
		public int leadingLegLeft;

		[Tooltip("Step phase. 0.5 - normal step. 0.1 - left right pause. 0.9 - right left pause")]
		[Range(0f, 1f)]
		public float phase;

		[Tooltip("The leg will try to get more support from behind")]
		[Range(0f, 1f)]
		public float lackOfSpeedCompensation;

		public float rewardSelf;

		public float rewardOthers;

		public float affectOthers;

		public float rewardPare;

		public float affectCounter;

		[HideInInspector]
		public float runJumpTime;

		public bool forceBipedalEarlyStep;

		[Tooltip("Reduce foot entanglement for bipedals")]
		public bool bipedalForbidPlacement;

		[Tooltip("Protects the body from fall through. Must be enabled if no colliders is used")]
		public bool protectBodyFromFallthrough;

		[Tooltip("Ceiling height which will not be seen as a floor, through which it fell. Don't make it too small, as it is critical on steep slopes")]
		public float protectBodyFromFallthroughMaxHeight;

		[Tooltip("0.5 - lower body between lands, 1 - no lowering, 1.5 - higher between lands (unnatural)")]
		[Range(0.5f, 1.5f)]
		[Header("Body movement")]
		public float downOnStep;

		public MotorBean horizontalMotor;

		public MotorBean verticalMotor;

		public MotorBean rotationMotor;

		[Tooltip("Center Of Gravity")]
		[Header("Center Of Gravity simulation (important for certain gait)")]
		public float cogUpDown;

		[Range(-0.5f, 0.5f)]
		[Tooltip("Rotate around Center Of Gravity")]
		public float cogAngle;

		public float cogRotationMultiplier;

		[Tooltip("Push acceleration to compensate Center Of Gravity")]
		public float cogAccel;

		[Tooltip("Rotation for the body to help steps length or oppose (-1 - clumsy, +1 - agile)")]
		[Range(-1f, 1f)]
		[Header("Body helps or opposes legs position")]
		public float bodyLenHelp;

		[Tooltip("Body helps the length in movement only")]
		public bool bodyLenHelpAtSpeedOnly;

		[Tooltip("Speed at which maximum rotation is achieved")]
		public float bodyLenHelpMaxSpeed;

		[Tooltip("Hip flexibility relative to the body")]
		[Header("Hip")]
		[Range(0f, 0.5f)]
		public float hipFlexibility;

		[HideInInspector]
		public Quaternion wantedHipRot;

		private Quaternion slowLocalHipRot;

		[Tooltip("Hip position relative to the body (center of its rotation)")]
		public Vector3 hipPosRel;

		[HideInInspector]
		public Vector3 hipPosAbs;

		[HideInInspector]
		public Quaternion hipRotAbs;

		[NonSerialized]
		public bool doTickHip;

		[Header("_system")]
		public bool collectSteppingHistory;

		public bool showPhaseDials;

		[HideInInspector]
		public Quaternion projectedRot;

		[HideInInspector]
		public Vector3 realSpeed;

		[HideInInspector]
		public Vector3 g;

		[HideInInspector]
		public Vector3 realBodyAngularSpeed;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 resultAcceleration;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 resultRotAcceleration;

		[HideInInspector]
		public Vector3 realBodyPos;

		[HideInInspector]
		public Quaternion realBodyRot;

		[HideInInspector]
		public Vector3 projPos;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 inputWantedPos;

		[HideInInspector]
		public Quaternion inputWantedRot;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 inputAnimPos;

		[HideInInspector]
		public Quaternion inputAnimRot;

		[NonSerialized]
		public ISurfaceDetector surfaceDetector;

		[NonSerialized]
		public List<MoveenSkelBase> legSkel;

		[NonSerialized]
		public List<Step2> steps;

		[NonSerialized]
		public Vector3 up;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 imCenter;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 imCenterSpeed;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 imCenterAngularSpeed;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 imBody;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 imBodySpeed;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 imActualCenterSpeed;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 speedLack;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 virtualForLegs;

		[HideInInspector]
		[InstrumentalInfo]
		public float midLen;

		private Quaternion oldHipLenHelp;

		[HideInInspector]
		public float emphasis;

		public Vector3 realWantedSpeed;

		public virtual void setWantedPos(float dt, Vector3 wantedPos, Quaternion wantedRot)
		{
		}

		public virtual void tick(float dt)
		{
		}

		[Optimize]
		private void tickHip(float dt)
		{
		}

		[Optimize]
		private void calcHipLenHelp()
		{
		}

		public virtual void tickSteps(float dt)
		{
		}

		private void calcAbs(float dt)
		{
		}

		public virtual void reset(Vector3 pos, Quaternion rot)
		{
		}

		public virtual Vector3 project(Vector3 input)
		{
			return default(Vector3);
		}
	}
}
