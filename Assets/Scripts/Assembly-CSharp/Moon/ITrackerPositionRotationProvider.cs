using UnityEngine;

namespace Moon
{
	public interface ITrackerPositionRotationProvider
	{
		void SetLeftHandPositionRotation(Transform leftHand);

		void SetRightHandPositionRotation(Transform rightHand);

		void SetHeadPositionRotation(Transform head);

		void SetBodyPositionRotation(Transform body);
	}
}
