using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public class BallExtraForceApplier : MonoBehaviour, IAddExtraForceFromHit
	{
		[SerializeField]
		private HitType _supportedHitType;

		[SerializeField]
		private Rigidbody _rigidbody;

		private IBallTagQuery _ballTagQuery;

		private bool _hasBallTagQuery;

		public HitType SupportedHitType => default(HitType);

		public event Action<HittableHitInfo, ForceMode, float> OnForceRequested
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<Vector3> OnVelocityOverrideRequested
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetBallTagQuery(IBallTagQuery ballTagQuery)
		{
		}

		void IAddExtraForceFromHit.SetRigidbody(Rigidbody rb)
		{
		}

		public void AddForce(Vector3 targetForce, ForceMode forceMode, HittableHitInfo hitInfo)
		{
		}

		public void AddForce(ForceMode forceMode, HittableHitInfo hitInfo)
		{
		}

		public void AddForce(ForceMode forceMode, HittableHitInfo hitInfo, float clampedMagnitude)
		{
		}

		public void ClearVelocity()
		{
		}

		public void MultiplyVelocity(float factor)
		{
		}
	}
}
