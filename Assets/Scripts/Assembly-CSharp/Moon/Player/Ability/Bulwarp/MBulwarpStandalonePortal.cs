using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.Arena;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Player.Ability.Bulwarp
{
	[NetworkBehaviourWeaved(10)]
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	public class MBulwarpStandalonePortal : NetworkBehaviour
	{
		[DefaultForProperty("IsActive", 0, 1)]
		[SerializeField]
		private NetworkBool _IsActive;

		[DefaultForProperty("TeleportActive", 1, 1)]
		private NetworkBool _TeleportActive;

		[DefaultForProperty("TargetPosition", 2, 3)]
		private Vector3 _TargetPosition;

		[DefaultForProperty("TargetRotation", 5, 4)]
		private Quaternion _TargetRotation;

		[DefaultForProperty("PortalActivateTimer", 9, 1)]
		private TickTimer _PortalActivateTimer;

		[SerializeField]
		private MBulwarpBallAreaDespawnableHitbox _ballAreaDespawnHitbox;

		[SerializeField]
		private MBulwarpPortalHandler _portalHandler;

		[SerializeField]
		private AnimationCurve _portalActivateDelayCurve;

		[SerializeField]
		private float _portalDuration;

		private BulwarpPlaceablePortalVisual _portalVisual;

		private Transform _connectedPortalPoint;

		private Transform _transform;

		private AbilityChargeConsumer _chargeConsumer;

		private static Changed<MBulwarpStandalonePortal> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MBulwarpStandalonePortal> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MBulwarpStandalonePortal> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

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

		public bool IsActiveLocally { get; private set; }

		[Networked]
		[NetworkedWeaved(1, 1)]
		private NetworkBool TeleportActive
		{
			get
			{
				return default(NetworkBool);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(2, 3)]
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
		[NetworkedWeaved(5, 4)]
		private Quaternion TargetRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(9, 1)]
		private TickTimer PortalActivateTimer
		{
			get
			{
				return default(TickTimer);
			}
			set
			{
			}
		}

		public event Action OnDisableLinkedPortalRequested
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

		public event Action OnDestroyLinkedPortalRequested
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

		public event Action OnExpiredOnServer
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

		public event Action OnPortalEnabledOnServer
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

		public event Action OnPortalHidden
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

		public event Action<float> OnPortalLifetimeUpdated
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

		private void Reset()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public void SetTeleportPoint(Transform connectedPortalPoint)
		{
		}

		public void PlaceOnServer(MPlayerHand mPlayerHand, Vector3 position, Quaternion rotation)
		{
		}

		public void ActivateTeleportation()
		{
		}

		public void DeactivateTeleportation()
		{
		}

		public void PlaceLocally(MPlayerHand mPlayerHand, Vector3 position, Quaternion rotation)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_Place(MPlayerHand mPlayerHand, Vector3 position, Quaternion rotation)
		{
		}

		private void PlaceInactivePortal(Vector3 position, Quaternion rotation)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_NotifyChargeChanged(float charge)
		{
		}

		private void PortalHandler_OnPortalDestroyRequested(int portalTravellerLayer)
		{
		}

		private void PortalHandler_OnPortalDisableRequested(int portalTravellerLayer)
		{
		}

		public void DespawnFromInputAuthority()
		{
		}

		private void ExpirePortal()
		{
		}

		[Rpc(RpcSources.StateAuthority | RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_HidePortal()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_EnableTeleportation()
		{
		}

		[Rpc(RpcSources.StateAuthority | RpcSources.InputAuthority, RpcTargets.All, InvokeResim = true)]
		private void Rpc_DisableTeleportation()
		{
		}

		private void ToggleTeleportationObjects(bool enable)
		{
		}

		private void HidePortal()
		{
		}

		public void DeactivateTeleportationLocally()
		{
		}

		public void SetTeamColor(TeamNo teamNo)
		{
		}

		public void TryUpdatePlacedPortalVisual()
		{
		}

		private void TryTogglePortalVisual(bool show)
		{
		}

		private void PlayPortalPlacedFx(MPlayerHand handPlacingShield)
		{
		}

		private void DespawnFromStateAuthority()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_Place_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_NotifyChargeChanged_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(3, 3, 7)]
		[Preserve]
		protected unsafe static void Rpc_HidePortal_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(4, 1, 7)]
		protected unsafe static void Rpc_EnableTeleportation_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(5, 3, 7)]
		protected unsafe static void Rpc_DisableTeleportation_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
