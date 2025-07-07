using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpGhostPlaceablePortal : BulwarpGhostPlaceable
	{
		[SerializeField]
		private MeshRenderer _ghostRenderer;

		[SerializeField]
		private Material _placeableMaterial;

		[SerializeField]
		private Material _intersectingMaterial;

		[SerializeField]
		private Material _restrictedAreaMaterial;

		[SerializeField]
		private float _portalPushSpeed;

		[SerializeField]
		private AnimationCurve _portalPushSpeedCurve;

		[SerializeField]
		private float _portalPushDistanceLimit;

		private ArenaBulwarpBoundaryArea _latestBoundaryArea;

		private Vector3 _nearestPlaceableAreaEdge;

		private Material _currentGhostMaterial;

		private bool _isInRestrictedArea;

		private Vector3 _currentPushDirection;

		private float _currentPushDistance;

		private Vector3 _currentHandPosition;

		private float _currentTimer;

		protected override void HandleOnShowGhostInternal(Vector3 handPosition, Vector3 handForwardDirection)
		{
		}

		protected override bool HasCustomUpdateGhostTransform()
		{
			return false;
		}

		protected override void HandleOnCustomUpdateGhostTransformInternal(Vector3 handPosition, float ghostOffsetFromHand)
		{
		}

		protected override PlacedState VerifyCurrentArea()
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

		private bool IsOutOfBounds(ArenaBulwarpBoundaryArea queryBox)
		{
			return false;
		}

		private void ShiftAwayFromObstacles(ArenaBulwarpBoundaryLine curBoundaryLine)
		{
		}

		private void TryAdjustYPosition(ArenaBulwarpBoundaryArea boundaryArea)
		{
		}

		protected override void OnDrawGizmos()
		{
		}
	}
}
