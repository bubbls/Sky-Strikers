using UnityEngine;

namespace Moon
{
	public interface IWeaponVisualWithVelocityTracker : IWeaponVisual
	{
		VelocityTracker VelocityTracker { get; }

		void ClearVelocityTracker();

		Vector3 GetWeaponSpecificVelocity();
	}
}
