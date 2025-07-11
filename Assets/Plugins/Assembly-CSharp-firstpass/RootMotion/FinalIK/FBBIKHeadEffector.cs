using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		public class BendBone
		{
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Range(0f, 1f)]
			[Tooltip("The weight of rotating this bone.")]
			public float weight;

			private Quaternion defaultLocalRotation;

			public BendBone()
			{
			}

			public BendBone(Transform transform, float weight)
			{
			}

			public void StoreDefaultLocalState()
			{
			}

			public void FixTransforms()
			{
			}
		}

		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Range(0f, 1f)]
		[LargeHeader("Position")]
		[Tooltip("Master weight for positioning the head.")]
		public float positionWeight;

		[Range(0f, 1f)]
		[Tooltip("The weight of moving the body along with the head")]
		public float bodyWeight;

		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[LargeHeader("Rotation")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		public float rotationWeight;

		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[LargeHeader("CCD")]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[Range(0f, 1f)]
		public float CCDWeight;

		[Tooltip("The weight of rolling the bones in towards the target")]
		[Range(0f, 1f)]
		public float roll;

		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Range(0f, 1f)]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		public float postStretchWeight;

		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Range(0f, 1f)]
		public float chestDirectionWeight;

		public Transform[] chestBones;

		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		private Vector3 offset;

		private Vector3 headToBody;

		private Vector3 shoulderCenterToHead;

		private Vector3 headToLeftThigh;

		private Vector3 headToRightThigh;

		private Vector3 leftShoulderPos;

		private Vector3 rightShoulderPos;

		private float shoulderDist;

		private float leftShoulderDist;

		private float rightShoulderDist;

		private Quaternion chestRotation;

		private Quaternion headRotationRelativeToRoot;

		private Quaternion[] ccdDefaultLocalRotations;

		private Vector3 headLocalPosition;

		private Quaternion headLocalRotation;

		private Vector3[] stretchLocalPositions;

		private Quaternion[] stretchLocalRotations;

		private Vector3[] chestLocalPositions;

		private Quaternion[] chestLocalRotations;

		private int bendBonesCount;

		private int ccdBonesCount;

		private int stretchBonesCount;

		private int chestBonesCount;

		private void Start()
		{
		}

		private void OnStoreDefaultLocalState()
		{
		}

		private void OnFixTransforms()
		{
		}

		private void OnPreRead()
		{
		}

		private void SpineBend()
		{
		}

		private void CCDPass()
		{
		}

		private void Iterate(int iteration)
		{
		}

		private void OnPostUpdate()
		{
		}

		private void ChestDirection()
		{
		}

		private void PostStretching()
		{
		}

		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
