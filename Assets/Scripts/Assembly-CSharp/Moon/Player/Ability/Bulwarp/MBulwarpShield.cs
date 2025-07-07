using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.AI.VisualScripting;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Bulwarp
{
	[SimulationBehaviour(Modes = (SimulationModes.Host | SimulationModes.Client))]
	[NetworkBehaviourWeaved(10)]
	public class MBulwarpShield : NetworkBehaviour
	{
		[SerializeField]
		[DefaultForProperty("IsActive", 0, 1)]
		private NetworkBool _IsActive;

		[SerializeField]
		[DefaultForProperty("IsPlacedInTeleportArea", 1, 1)]
		private NetworkBool _IsPlacedInTeleportArea;

		[DefaultForProperty("IsTeleportEnabled", 2, 1)]
		private NetworkBool _IsTeleportEnabled;

		[DefaultForProperty("TargetPosition", 3, 3)]
		private Vector3 _TargetPosition;

		[DefaultForProperty("SpawnRotation", 6, 4)]
		private Quaternion _SpawnRotation;

		[SerializeField]
		private MBulwarpBallAreaDespawnableHitbox _ballAreaDespawnHitbox;

		[SerializeField]
		private MBulwarpPortalHandler _portalHandler;

		[SerializeField]
		private GameObject _portalEnabledColliders;

		[SerializeField]
		private GameObject _portalDisabledColliders;

		[SerializeField]
		private GameObject _colliderParent;

		[SerializeField]
		private Collider[] _physicsColliders;

		[SerializeField]
		private float _collidersEnableDurationAfterPushingPlayer;

		[SerializeField]
		private Vector3 _pushPlayerPower;

		[SerializeField]
		private OverlapShapeDesc _pushPlayerBounds;

		private Transform _transform;

		private BulwarpPlaceableShieldVisual _shieldVisual;

		private float _maxMoveDistance;

		private float _collidersEnableTime;

		private bool _playerPushed;

		private bool _isPendingSpawn;

		private bool _isPlacedInTeleportArea;

		private static Changed<MBulwarpShield> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBulwarpShield> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBulwarpShield> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
		public NetworkBool IsActive
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		[NetworkedWeaved(1, 1)]
		[Networked]
		public NetworkBool IsPlacedInTeleportArea
		{
			get
			{
				return default(NetworkBool);
			}
			private set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 1)]
		private NetworkBool IsTeleportEnabled
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[NetworkedWeaved(3, 3)]
		[Networked]
		private Vector3 TargetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(6, 4)]
		private Quaternion SpawnRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public bool IsActiveLocally { get; private set; }

		public event Action OnShieldPortalDisabled
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

		public event Action OnShieldDestroyed
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

		public event Action OnShieldDespawnedInBallArea
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

		public event Action OnPlacedOnStateAuthority
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

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public void SetTeamColor(TeamNo curTeamNo)
		{
		}

		[Rpc(RpcSources.StateAuthority | RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_ToggleTeleporting(bool enable)
		{
		}

		public void PlaceOnInputAuthority(MPlayerHand handPlacingShield, Vector3 position, Quaternion rotation, bool isTeleportable, MBulwarpPlaceablesController.ShieldCreateSource shieldCreateSource)
		{
		}

		[Rpc(RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true, TickAligned = false)]
		private void Rpc_Place(MPlayerHand mplayerHand, Vector3 position, Quaternion rotation, bool isPlacedInTeleportArea, MBulwarpPlaceablesController.ShieldCreateSource shieldCreateSource)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.InputAuthority, InvokeResim = true)]
		private void Rpc_ShowAsPlacedOnServer()
		{
		}

		private void PlaceShield(MPlayerHand handPlacingShield, Vector3 position, Quaternion rotation)
		{
		}

		private void TryPushLocalPlayer()
		{
		}

		private void PortalHandler_OnPortalDisableRequested(int portalTravellerLayer)
		{
		}

		private void DestroyShield(int portalTravellerLayer)
		{
		}

		public void DespawnFromInputAuthority()
		{
		}

		[Rpc(RpcSources.StateAuthority | RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_Despawned()
		{
		}

		private void Despawn()
		{
		}

		public void ActivatePortal()
		{
		}

		public void DeactivatePortal()
		{
		}

		private void TogglePortalTriggerColliders(bool portalEnabled)
		{
		}

		private void ToggleCollisionWithPlayers(bool enable)
		{
		}

		private void ToggleColliders(bool enable)
		{
		}

		private bool IsPlayerInPushColliderBounds()
		{
			return false;
		}

		private bool IsInPushColliderBounds(params Vector3[] positions)
		{
			return false;
		}

		private void TryToggleShieldVisual(bool show)
		{
		}

		private void TryTogglePortalOnShield(bool show)
		{
		}

		public void TryUpdatePlacedShieldVisual()
		{
		}

		private void PlayShieldPlacedFx(MPlayerHand handPlacingShield)
		{
		}

		public void UpdateShieldPortalVisualLifetime(float remainingLifetime)
		{
		}

		private void DespawnInBallArea()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 3, 7)]
		[Preserve]
		protected unsafe static void Rpc_ToggleTeleporting_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 2, 7)]
		[Preserve]
		protected unsafe static void Rpc_Place_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 1, 2)]
		protected unsafe static void Rpc_ShowAsPlacedOnServer_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(4, 3, 7)]
		[Preserve]
		protected unsafe static void Rpc_Despawned_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
