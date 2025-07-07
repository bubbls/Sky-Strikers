using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpGhostPlaceableShield : BulwarpGhostPlaceable
	{
		[SerializeField]
		private Material _placeableMaterial;

		[SerializeField]
		private Material _notTeleportableMaterial;

		[SerializeField]
		private Material _restrictedAreaMaterial;

		[SerializeField]
		private GameObject _increasedCooldownVisual;

		[SerializeField]
		private Vector3 _leftHandRotationOffset;

		[SerializeField]
		private Vector3 _rightHandRotationOffset;

		[SerializeField]
		private Transform _offsetTransform;

		private ArenaBulwarpBoundaryArea _latestBoundaryArea;

		private bool _isInPlaceableArea;

		private Material _currentGhostMaterial;

		private BulwarpPlaceableShieldVisual _curShieldVisual;

		private bool _isInRestrictedArea;

		public override void SetPlaceableTheme(SuitWeaponVisualTheme suitWeaponVisualTheme)
		{
		}

		private void LoadGhostVisuals(BulwarpSuitWeaponVisualThemeScheme scheme)
		{
		}

		public override void ShowGhost(MPlayerHand hand)
		{
		}

		protected override PlacedState VerifyCurrentArea()
		{
			return default(PlacedState);
		}

		public PlacedState GetPlacementState()
		{
			return default(PlacedState);
		}

		public override bool TryPlaceGhost()
		{
			return false;
		}

		private void TogglePlaceableVisuals(PlacedState placedState)
		{
		}

		private void ShowRestrictedAreaVisuals()
		{
		}

		private bool VerifyClearanceFromSurface(Vector3 position)
		{
			return false;
		}

		protected override void OnDrawGizmos()
		{
		}
	}
}
