using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using moveen.utils;

namespace moveen.core
{
	[Serializable]
	public class Step2
	{
		[NonSerialized]
		public Transform thisTransform;

		private static int nextId;

		[NonSerialized]
		[InstrumentalInfo]
		public int internalId;

		[Tooltip("Put the foot closer on steep slopes")]
		public bool handleSteepSlopes;

		[Tooltip("Limit max step height (may lead to slippage)")]
		public bool limitMaxStepHeight;

		[Tooltip("Absolute max step height")]
		public float maxStepHeight;

		[Tooltip("Off: comfortPosRel will be same as the leg tip.\nOn: comfortPosRel can be defined separately from the leg tip.")]
		public bool detachedComfortPosRel;

		[Tooltip("Best (comfort) leg position")]
		[FormerlySerializedAs("bestTargetRel")]
		public Vector3 comfortPosRel;

		[HideInInspector]
		public ISurfaceDetector surfaceDetector;

		[HideInInspector]
		public List<StepNeuro<Step2>> affectedByProgress;

		[HideInInspector]
		public List<StepNeuro<Step2>> affectedByDeviation;

		[HideInInspector]
		public List<StepNeuro<Step2>> affectedByDir;

		[Header("Step dynamics (consider increasing of speeds if stepping is odd)")]
		[Tooltip("Minimal leg stepping speed")]
		public float stepSpeedMin;

		[Tooltip("Leg stepping speed X body speed dependency")]
		public float stepSpeedBodySpeedMul;

		[Tooltip("Leg stepping speed X body rotation speed dependency")]
		public float stepSpeedBodyRotSpeedMul;

		public float maxAcceleration;

		[Tooltip("Pause between leg decided to step, and it actually ups (0 for very light walk, 0.2 and more to add more weight)")]
		public float undockPause;

		[HideInInspector]
		public float airTime;

		[HideInInspector]
		[InstrumentalInfo]
		public bool wasTooLong;

		[HideInInspector]
		[InstrumentalInfo]
		public bool dockedState;

		[HideInInspector]
		public Vector3 bodyPos;

		[HideInInspector]
		public Quaternion bodyRot;

		[HideInInspector]
		public Quaternion projectedRot;

		[HideInInspector]
		public Vector3 bodySpeed;

		[HideInInspector]
		public Vector3 additionalDisplacement;

		[HideInInspector]
		public Vector3 terrainNormal;

		[HideInInspector]
		public float pursueBodySpeed;

		[NonSerialized]
		public Vector3 bodyForward;

		[NonSerialized]
		public Vector3 bodyUp;

		[Tooltip("Show possible step trajectory")]
		[Header("Step geometry")]
		public bool showTrajectory;

		[Tooltip("Step radius multiplier. Some leg layouts may require modification of default value")]
		public float comfortRadiusRatio;

		[HideInInspector]
		[InstrumentalInfo]
		public float comfortRadius;

		[Tooltip("Speed, with which foot is orienting in body's direction while in air")]
		public int footOrientationSpeed;

		private Quaternion possibleFootOrientation;

		[HideInInspector]
		public Quaternion footOrientation;

		[FloatWarning(min = 0f)]
		[Tooltip("Parameter for step trajectory, turn on 'showTrajectory' and look at changes")]
		public float targetDockR;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 targetTo;

		[Tooltip("Parameter for step trajectory, turn on 'showTrajectory' and look at changes")]
		[FloatWarning(min = 0f)]
		public float undockInitialStrength;

		[Tooltip("Parameter for step trajectory, turn on 'showTrajectory' and look at changes")]
		[FloatWarning(min = 0f)]
		public float undockTime;

		[HideInInspector]
		public float undockHDif;

		public bool emergencyDown;

		[NonSerialized]
		public bool forbidHalf;

		[NonSerialized]
		public Vector3 forbidHalfPos;

		[NonSerialized]
		public Vector3 forbidHalfDir;

		[NonSerialized]
		public bool isExample;

		[HideInInspector]
		[InstrumentalInfo]
		public bool switchToBottom;

		[HideInInspector]
		[InstrumentalInfo]
		public bool wasUnderground;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 curTarget;

		[HideInInspector]
		[InstrumentalInfo]
		public float speedSlow;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 calcTarget;

		[InstrumentalInfo]
		[HideInInspector]
		public float legAlt;

		[HideInInspector]
		[InstrumentalInfo]
		public float lastStepLen;

		[HideInInspector]
		[InstrumentalInfo]
		public float lastDockedLen;

		[HideInInspector]
		[InstrumentalInfo]
		public float lastAirLen;

		[HideInInspector]
		[InstrumentalInfo]
		public float lastAirTime;

		[HideInInspector]
		[InstrumentalInfo]
		public float lastLandTime;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 lastDockedAtLocal;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 lastUndockedAtLocal;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 basisAbs;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 acceleration;

		[HideInInspector]
		[InstrumentalInfo]
		public float comfortFromSkel;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 bestTargetConservativeAbs;

		[InstrumentalInfo]
		[HideInInspector]
		public Vector3 bestTargetConservativeUnprojAbs;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 bestTargetConservativeUnprojAbs2;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 bestTargetProgressiveAbs;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 posAbs;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 wantedSpeed;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 speedAbs;

		[HideInInspector]
		[InstrumentalInfo]
		public float undockPauseCur;

		[HideInInspector]
		[InstrumentalInfo]
		public float undockUpLength;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 undockVec;

		[HideInInspector]
		[InstrumentalInfo]
		public float undockProgress;

		[InstrumentalInfo]
		[HideInInspector]
		public float undockCurTime;

		[HideInInspector]
		[InstrumentalInfo]
		public float maxLen;

		[HideInInspector]
		[InstrumentalInfo]
		public float fromAbove;

		[HideInInspector]
		[InstrumentalInfo]
		public float landTime;

		[HideInInspector]
		[InstrumentalInfo]
		public float deviation;

		[InstrumentalInfo]
		[HideInInspector]
		public float progress;

		[InstrumentalInfo]
		[HideInInspector]
		public float timedProgress;

		[HideInInspector]
		[InstrumentalInfo]
		public float beFaster;

		[HideInInspector]
		[InstrumentalInfo]
		public float legSpeed;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 g;

		[NonSerialized]
		public bool collectSteppingHistory;

		public CounterStacksCollection paramHistory;

		[HideInInspector]
		public Vector3 oldPosAbs;

		[HideInInspector]
		[InstrumentalInfo]
		public float airParam;

		[HideInInspector]
		[InstrumentalInfo]
		public bool canGoAir;

		[HideInInspector]
		[InstrumentalInfo]
		public Vector3 airTarget;

		private float deviationUnclamped;

		[NonSerialized]
		private P<Vector3> tmp;

		public float cycleTime;

		public float curCycle;

		[NonSerialized]
		public bool prepare;

		public virtual void calcAbs(float dt, Vector3 futurePos, Quaternion futureRot)
		{
		}

		[Optimize]
		public virtual void tick(float dt)
		{
		}

		private void history()
		{
		}

		private void tickProgress()
		{
		}

		[Optimize]
		public virtual void tickFoot(float dt)
		{
		}

		public virtual void checkTooLong()
		{
		}

		public virtual void beginStep(float undockStrength)
		{
		}

		public virtual void reset(Vector3 pos, Quaternion rot)
		{
		}

		public static Vector3 toAbs(Vector3 abs, Vector3 pos, Quaternion rot)
		{
			return default(Vector3);
		}

		public virtual void targetFill(P<Vector3> pvec)
		{
		}

		public virtual void undockTick(float dt)
		{
		}
	}
}
