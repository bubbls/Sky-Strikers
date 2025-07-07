using System;
using Chamber8.Framework.Messaging;
using DP.Takeaway.Utils;
using Fusion;
using Moon.Arena;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Bulwarp
{
	[SimulationBehaviour(Stages = SimulationStages.Forward, Modes = (SimulationModes.Host | SimulationModes.Client))]
	[NetworkBehaviourWeaved(0)]
	[OrderAfter(new Type[] { typeof(MPlayerAbilityBulwarp) })]
	public class MBulwarpPlaceablesController : NetworkBehaviour
	{
		public enum ShieldCreateSource : byte
		{
			None = 0,
			ChargeOver = 1,
			AmmoBullet = 2
		}

		[SerializeField]
		private float _maxPlayerDistanceFromShield;

		[SerializeField]
		private float _shieldRechargeDuration;

		[SerializeField]
		private float _shieldCantTeleportRechargeDuration;

		[SerializeField]
		private float _shieldDestroyedRechargeDuration;

		[SerializeField]
		private MBulwarpShield _shield;

		[SerializeField]
		private MBulwarpStandalonePortal _standalonePortal;

		[SerializeField]
		private Location _locationsToDespawnPlaceables;

		[SerializeField]
		private float _chargeSyncInterval;

		private BulwarpSuitWeaponsGhosts _suitWeaponsGhosts;

		private LocalPlayerRig _localPlayerRig;

		private BulwarpShieldChargeHandler _chargeHandler;

		private IMessageSubscriber[] _subscribers;

		private SuitVisualTheme _curVisualTheme;

		private SuitWeaponVisualTheme _curSuitWeaponVisualTheme;

		private TeamNo _curTeamNo;

		private Cooldown _chargeSyncIntervalCd;

		private float _playerDistanceFromShield;

		private bool _isInitialized;

		private ShieldCreateSource _shieldCreateSource;

		private static Changed<MBulwarpPlaceablesController> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBulwarpPlaceablesController> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBulwarpPlaceablesController> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		private MPlayer Player => null;

		public void Initialize()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		private void ResetPlaceablesController()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		private void LateUpdate()
		{
		}

		public void OnTriggerPressed(MPlayerHand mPlayerHand, bool isPressingGrab)
		{
		}

		public void OnTriggerReleased(MPlayerHand mPlayerHand)
		{
		}

		public void OnGrabPressed(MPlayerHand mPlayerHand, bool isHandHoldingWeapon, bool isHandPressingTrigger)
		{
		}

		public void OnGrabReleased(MPlayerHand mPlayerHand)
		{
		}

		private void TryShowGhostPortal(MPlayerHand mPlayerHand)
		{
		}

		private void PlaceShield(MPlayerHand hand, Vector3 position, Quaternion rotation, BulwarpGhostPlaceable.PlacedState placedState, ShieldCreateSource shieldCreateSource)
		{
		}

		private void Shield_OnPlacedOnStateAuthority()
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true, TickAligned = false)]
		private void Rpc_NotifyShieldChargeChanged(float charge)
		{
		}

		private void Shield_OnShieldPortalDisabled()
		{
		}

		private void Shield_OnShieldDestroyed()
		{
		}

		private void Shield_OnShieldDespawnedInBallArea()
		{
		}

		private void HandleOnPlayerExitShieldRange()
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.StateAuthority, InvokeResim = true, TickAligned = false)]
		private void Rpc_PlacePortalOnServer(MPlayerHand mPlayerHand, Vector3 position, Quaternion rotation)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority, InvokeResim = true)]
		private void Rpc_PlacePortalFailed()
		{
		}

		private void StandalonePortal_OnStandalonePortalEnabledOnServer()
		{
		}

		private void StandalonePortal_OnExpiredOnServer()
		{
		}

		private void StandalonePortal_OnPortalHidden()
		{
		}

		private void StandalonePortal_OnDisableLinkedStandalonePortalRequested()
		{
		}

		private void StandalonePortal_OnDestroyLinkedStandalonePortalRequested()
		{
		}

		private void StandalonePortal_OnPortalLifetimeUpdated(float remainingLifetime)
		{
		}

		private int HandleOnMatchEvent(IMessage<MatchEventMessage> message)
		{
			return 0;
		}

		private int HandleGeneralMessage(IMessage<GeneralMessage> message)
		{
			return 0;
		}

		private int HandlePlayerLocationChangedMessage(IMessage<PlayerLocationChangedMessage> message)
		{
			return 0;
		}

		private void TryDespawnAllBasedOnLocation(Location currentLocation, Location prevLocation)
		{
		}

		private void DespawnAllFromInputAuthority()
		{
		}

		public void HandleOnPlayerInfoUpdated(PlayerInfo playerInfo)
		{
		}

		public void HandleOnPlayerSuitVisualsUpdated()
		{
		}

		private void VerifyPlayerDistance()
		{
		}

		private void GuardianShieldChargeHandler_OnChargeFull()
		{
		}

		private void PlayLastBulletUsedSound()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 2, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyShieldChargeChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 2, 1)]
		[Preserve]
		protected unsafe static void Rpc_PlacePortalOnServer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 1, 2)]
		protected unsafe static void Rpc_PlacePortalFailed_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
