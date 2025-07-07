using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Events;

namespace Moon.Player.Ability.Bulwarp
{
	public class BulwarpPlaceableShieldVisual : VisualBase
	{
		[SerializeField]
		private MeshRenderer _shieldRenderer;

		[SerializeField]
		private PlayerTeamObjectsGroup _teamObjectsGroup;

		[SerializeField]
		private GameObject _localPlayerOnlyVisuals;

		[SerializeField]
		private GameObject _portalVisuals;

		[SerializeField]
		private PortalLifetimeVisual[] _portalLifetimeVisuals;

		[SerializeField]
		private AnimationCurve _portalSizeCurve;

		[SerializeField]
		private float _portalSizeChangeSpeed;

		[SerializeField]
		private ParticleSystem[] _placedFxs;

		[SerializeField]
		private UnityEvent _onSetupAsGhost;

		private bool _portalActive;

		private bool _isInTeleportArea;

		private float _portalLifetimeRemainingNormalized;

		private float _portalTargetScale;

		private BulwarpSuitWeaponVisualThemeScheme.ShieldMaterials[] _shieldMaterials;

		public void Initialize(PlayerRef ownerPlayer, bool isLocalPlayer, TeamNo teamNo, bool isPendingSpawnOnServer, bool isInTeleportArea)
		{
		}

		public void ResetVisual()
		{
		}

		public void SetShieldMaterials(BulwarpSuitWeaponVisualThemeScheme.ShieldMaterials[] shieldMaterials)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetTeamColor(TeamNo teamNo, bool isInTeleportArea)
		{
		}

		public override void SetTeamColor(TeamNo teamNo)
		{
		}

		public void ApplyMaterial(Material material)
		{
		}

		public void PlayPlacedFx()
		{
		}

		public void TogglePortalVisuals(bool enable)
		{
		}

		public void UpdatePortalVisualLifetime(float remainingLifetime)
		{
		}

		public override void EnableHologramMaterial()
		{
		}

		public void SetupAsGhost(Material currentGhostMaterial)
		{
		}
	}
}
