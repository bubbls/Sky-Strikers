using System;
using UnityEngine;
using moveen.utils;

namespace moveen.descs
{
	[ExecuteInEditMode]
	public class MoveenSkelBase : OrderedMonoBehaviour
	{
		public Transform target;

		public Vector3 targetPosRel;

		public Quaternion targetRotRel;

		[ReadOnly]
		public Vector3 targetPos;

		[ReadOnly]
		public Quaternion targetRot;

		public bool useLimits;

		public float minLen;

		public float maxLen;

		[ReadOnly]
		public float comfort;

		[ReadOnly]
		public Vector3 limitedResultTarget;

		[NonSerialized]
		[HideInInspector]
		public bool needsUpdate;

		[NonSerialized]
		[HideInInspector]
		public bool needsReset;

		[HideInInspector]
		public Vector3 footLocal;

		public void checkNeeds()
		{
		}

		public override void tick(float dt)
		{
		}

		private void setForNoTarget()
		{
		}

		public virtual void updateLimitedResult()
		{
		}

		public virtual void setTarget(Vector3 targetPos, Quaternion targetRot)
		{
		}

		public virtual void updateData()
		{
		}

		public virtual void reset()
		{
		}

		public override void OnValidate()
		{
		}
	}
}
