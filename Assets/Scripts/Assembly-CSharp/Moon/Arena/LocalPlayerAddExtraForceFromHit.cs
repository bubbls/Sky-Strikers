using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public class LocalPlayerAddExtraForceFromHit : MonoBehaviour, IAddExtraForceFromHit
	{
		[SerializeField]
		private HitType _supportedHitType;

		[SerializeField]
		private Rigidbody _rigidbody;

		private Vector3 _lastAppliedForce;

		private bool _allowExternalForceApplication;

		public HitType SupportedHitType => default(HitType);

		public event Action<HittableHitInfo> OnBeforeForceAppliedFromHit
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

		private void Awake()
		{
		}

		public void SetRigidbody(Rigidbody rb)
		{
		}

		public void ToggleExternalForceApplication(bool allow)
		{
		}

		public void AddForce(Vector3 targetForce, ForceMode forceMode, HittableHitInfo hitInfo)
		{
		}

		private bool IsAllowedToApplyForce(HittableHitInfo hitInfo)
		{
			return false;
		}
	}
}
