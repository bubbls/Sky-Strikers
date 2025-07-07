using Fusion;
using UnityEngine;

namespace Moon.Arena
{
	public interface IAddExtraForceFromHit
	{
		HitType SupportedHitType { get; }

		void SetRigidbody(Rigidbody rb);

		void AddForce(Vector3 targetForce, ForceMode forceMode, HittableHitInfo hitInfo);
	}
}
