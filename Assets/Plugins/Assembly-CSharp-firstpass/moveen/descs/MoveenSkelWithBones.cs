using System;
using System.Collections.Generic;
using UnityEngine;
using moveen.core;

namespace moveen.descs
{
	[ExecuteInEditMode]
	public abstract class MoveenSkelWithBones : MoveenSkelBase
	{
		[HideInInspector]
		public List<Vector3> wanteds;

		[Range(0f, 1f)]
		public float transition;

		public List<Transform> bonesGeometry;

		[NonSerialized]
		public bool isInError;

		[NonSerialized]
		public List<Bone> bones;

		[HideInInspector]
		public List<Vector3> bonesDeltaPos;

		[HideInInspector]
		public List<Quaternion> bonesDeltaRot;

		[HideInInspector]
		public Vector3 basePos;

		[HideInInspector]
		public Quaternion baseRot;

		[NonSerialized]
		private bool canExpectExternalChange;

		public override void tick(float dt)
		{
		}

		public virtual void tickStructure(float dt)
		{
		}

		public override void updateData()
		{
		}

		private void updateBones()
		{
		}

		private void updateDeltas()
		{
		}

		private void copyTransforms()
		{
		}

		private void copyChildrenTransformsDeltless()
		{
		}

		public virtual void createRagdoll()
		{
		}

		public static Transform getAffected(MoveenSkelWithBones bones, int i)
		{
			return null;
		}

		public static CharacterJoint connectToParentCharacterJoint(Transform a, Transform p)
		{
			return null;
		}

		public static void connectToParentHingeJoint(Transform a, Transform p, Vector3 jointAxis)
		{
		}

		public static T ensureOneComponent<T>(Transform t) where T : Component
		{
			return null;
		}

		public static void createCapsule(Transform target, Quaternion rot, float height)
		{
		}

		public static void createCapsule2(Transform target, float height, float radius)
		{
		}

		public override void OnValidate()
		{
		}

		public override void reset()
		{
		}

		public virtual bool canBeSolved()
		{
			return false;
		}
	}
}
