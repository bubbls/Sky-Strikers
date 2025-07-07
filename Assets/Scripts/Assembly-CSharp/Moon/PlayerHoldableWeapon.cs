using UnityEngine;

namespace Moon
{
	public class PlayerHoldableWeapon : MonoBehaviour
	{
		private IWeaponVisual _weaponVisual;

		private IWeaponVisualWithVelocityTracker _weaponVisualWithVelocityTracker;

		private bool _shouldShowWeapon;

		private bool _isWeaponSpawnedOnServer;

		[SerializeField]
		[Header("Editor Runtime Debugging Only, Leave Blank")]
		[Space(5f)]
		private Object _weaponVisualObjectRef;

		public void ToggleVisibility(bool show, bool force = false)
		{
		}

		public void SetWeaponSpawnedOnServerState(bool isSpawnedOnServer)
		{
		}

		public void SetVisual(IWeaponVisual visual)
		{
		}

		public void ApplyGlobalVelocityTrackerConfiguration(Transform trackingSpace)
		{
		}

		public void ResetVelocityTrackers()
		{
		}

		public Vector3 ThrowVelocity()
		{
			return default(Vector3);
		}
	}
}
