using UnityEngine;

namespace Moon.Interaction
{
	public interface IDistanceRestrictedGrabbable
	{
		Vector3 DistanceCheckPointPosition { get; }

		float MaxGrabDistance { get; }
	}
}
