using System;
using System.Runtime.CompilerServices;
using Fusion;
using Moon.MultiPlay;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(3)]
	public class MHubArenaPortal : NetworkBehaviour
	{
		[SerializeField]
		[DefaultForProperty("Lifetime", 0, 1)]
		private float _Lifetime;

		[SerializeField]
		[DefaultForProperty("ConnectedPortal", 1, 2)]
		private MHubArenaPortal _ConnectedPortal;

		[SerializeField]
		private MHubArenaPortalHandler _portalHandler;

		[SerializeField]
		private HubArenaPortalVisual portalPrefab;

		private HubArenaPortalVisual _portalVisual;

		private float _remainingTime;

		private static Changed<MHubArenaPortal> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MHubArenaPortal> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MHubArenaPortal> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked]
		[NetworkedWeaved(0, 1)]
		public float Lifetime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Networked]
		[NetworkedWeaved(1, 2)]
		public MHubArenaPortal ConnectedPortal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MHubArenaPortalHandler PortalHandler => null;

		public event Action<MHubArenaPortal> OnPortalSpawned
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

		public event Action<MHubArenaPortal, int> OnPortalUsed
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

		public event Action<MHubArenaPortal> OnPortalDespawned
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

		private void PortalHandler_OnPortalDestroyRequested(int portalTravellerLayer)
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
		{
		}

		public void ConnectToPortal(MHubArenaPortal connectedPortal)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_ConnectToPortal(MHubArenaPortal connectedPortal)
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 1, 7)]
		protected unsafe static void Rpc_ConnectToPortal_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
