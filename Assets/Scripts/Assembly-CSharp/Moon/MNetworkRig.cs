using System;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;

namespace Moon
{
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	[OrderAfter(new Type[]
	{
		typeof(NetworkTransform),
		typeof(NetworkRigidbody)
	})]
	public class MNetworkRig : SimulationBehaviour, ITrackerPositionRotationProvider
	{
		[SerializeField]
		private NetworkTransform _mRig;

		[SerializeField]
		private NetworkTransform _mHead;

		[SerializeField]
		private NetworkTransform _mBody;

		[SerializeField]
		private NetworkTransform _mLeftHand;

		[SerializeField]
		private NetworkTransform _mRightHand;

		private Transform _cachedTransform;

		private Transform _cachedTracker;

		private LocalPlayerRig _localPlayerRig;

		private bool _hasLocalPlayerRig;

		public NetworkTransform LeftHand => null;

		public NetworkTransform RightHand => null;

		public NetworkTransform Head => null;

		public NetworkTransform Body => null;

		public void SetLocalPlayerRig(LocalPlayerRig localPlayerRig)
		{
		}

		public void AcceptInput(PlayerInputData inputData)
		{
		}

		public override void Render()
		{
		}

		public Vector3 GetInterpolatedBodyPosition()
		{
			return default(Vector3);
		}

		public Transform GetHeadTransform()
		{
			return null;
		}

		public Transform GetInterpolatedHeadTransform()
		{
			return null;
		}

		public Transform GetInterpolatedBodyTransform()
		{
			return null;
		}

		public Transform GetBodyTransform()
		{
			return null;
		}

		public void SetLeftHandPositionRotation(Transform leftHand)
		{
		}

		public void SetRightHandPositionRotation(Transform rightHand)
		{
		}

		public void SetHeadPositionRotation(Transform head)
		{
		}

		public void SetBodyPositionRotation(Transform body)
		{
		}
	}
}
