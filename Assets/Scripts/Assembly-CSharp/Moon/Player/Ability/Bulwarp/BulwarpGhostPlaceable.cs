using System;
using System.Runtime.CompilerServices;
using Moon.AI.VisualScripting;
using UnityEngine;

namespace Moon.Player.Ability.Bulwarp
{
	public abstract class BulwarpGhostPlaceable : MonoBehaviour
	{
		public enum PlacedState
		{
			None = 0,
			IsCorrectlyInTeleportArea = 1,
			IsIncorrectlyInTeleportArea = 2,
			IsOutOfTeleportArea = 3
		}

		[SerializeField]
		private float _ghostOffsetFromHand;

		[SerializeField]
		protected Transform _forwardReference;

		[SerializeField]
		protected OverlapShapeDesc _objBounds;

		[SerializeField]
		protected Transform[] _placeableAreaCheckPoints;

		[SerializeField]
		protected float _minClearanceFromSurfaces;

		[SerializeField]
		protected float _minClearanceFromEdge;

		private MPlayerHand _curMPlayerHand;

		private SuitWeaponVisualTheme _suitWeaponVisualTheme;

		private PlacedState _lastPlacementState;

		private int _placeStateSoundId;

		private readonly Collider[] _overlapResults;

		private int _cachedOverlapCount;

		private bool _hasOverlap;

		public Vector3 CurrentPosition { get; protected set; }

		public Quaternion ForwardRotation { get; protected set; }

		protected Transform HandToFollow { get; private set; }

		protected Transform Transform { get; private set; }

		protected bool MeetsRequirementsForTeleport { get; set; }

		protected ArenaBulwarpBoundaryLine CurBoundaryLine { get; set; }

		public event Action OnGhostShown
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

		public event Action OnGhostHidden
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

		public virtual void SetPlaceableTheme(SuitWeaponVisualTheme suitWeaponVisualTheme)
		{
		}

		public virtual void ShowGhost(MPlayerHand hand)
		{
		}

		protected virtual void HandleOnShowGhostInternal(Vector3 currentHandPosition, Vector3 handDirection)
		{
		}

		private void OnDestroy()
		{
		}

		public bool IsHandControllingGhost(MPlayerHand hand)
		{
			return false;
		}

		public bool IsBeingControlled()
		{
			return false;
		}

		private void LateUpdate()
		{
		}

		private void UpdateGhostTransform()
		{
		}

		protected virtual bool HasCustomUpdateGhostTransform()
		{
			return false;
		}

		protected virtual void HandleOnCustomUpdateGhostTransformInternal(Vector3 handPosition, float ghostOffsetFromHand)
		{
		}

		public void Hide()
		{
		}

		protected abstract PlacedState VerifyCurrentArea();

		public abstract bool TryPlaceGhost();

		protected virtual void OnDrawGizmos()
		{
		}

		protected bool HasMinClearanceFromSurfaces(Vector3 position)
		{
			return false;
		}

		protected bool IsOverlappingWithSurface()
		{
			return false;
		}

		protected bool VerifyNotIntersectingSurfaceFromHand(bool checkForIgnoreColliders = true)
		{
			return false;
		}

		protected bool CheckIfAllRayResultsCanBeIgnored(int count)
		{
			return false;
		}

		protected bool ValidateYPosition(ArenaBulwarpBoundaryArea area)
		{
			return false;
		}

		protected void TryPlayPlaceableStateChangeSfx(PlacedState currentState)
		{
		}

		private void TryStopCurrentSound()
		{
		}
	}
}
