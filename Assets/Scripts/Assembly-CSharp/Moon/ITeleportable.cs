using UnityEngine;

namespace Moon
{
	public interface ITeleportable
	{
		Vector3 GetTeleportableTransformPosition();

		void Teleport(Transform thisPlace, Transform otherPlace, bool keepVelocity = false, bool freezeAfterTeleport = false);
	}
}
