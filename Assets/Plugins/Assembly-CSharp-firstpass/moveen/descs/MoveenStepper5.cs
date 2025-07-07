using System;
using UnityEngine;
using moveen.core;
using moveen.utils;

namespace moveen.descs
{
	[ExecuteInEditMode]
	public class MoveenStepper5 : OrderedMonoBehaviour
	{
		public static bool showInstrumentalInfo;

		[Tooltip("Body")]
		public Transform body;

		[NonSerialized]
		public Rigidbody bodyRigid;

		[Tooltip("Hip (not necessary)")]
		public Transform hip;

		[Tooltip("Main animation engine")]
		public Stepper5 engine;

		[HideInInspector]
		public Vector3 rootLocalPos;

		[HideInInspector]
		public Quaternion bodyDeltaR;

		[HideInInspector]
		public Vector3 hipDeltaPos;

		[HideInInspector]
		public Quaternion hipDeltaRot;

		[NonSerialized]
		public bool needsReset;

		[NonSerialized]
		public bool needsUpdate;

		[NonSerialized]
		public Vector3 targetPos;

		[NonSerialized]
		public Quaternion targetRot;

		[NonSerialized]
		private int lastLegsCount;

		[NonSerialized]
		private bool initialUpdateWasCalled;

		public void checkNeeds()
		{
		}

		public override void OnEnable()
		{
		}

		public void updateData()
		{
		}

		public void reset()
		{
		}

		public override void tick(float dt)
		{
		}

		public override void fixedTick(float dt)
		{
		}

		private void updateDeltas()
		{
		}

		public int calcActualLegsCount()
		{
			return 0;
		}

		public override void OnValidate()
		{
		}
	}
}
