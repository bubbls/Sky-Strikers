using System;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.Hub
{
	[NetworkBehaviourWeaved(3)]
	public class MTutorialPortal : NetworkBehaviour
	{
		[SerializeField]
		[DefaultForProperty("Lifetime", 0, 1)]
		private float _Lifetime;

		[SerializeField]
		[DefaultForProperty("ConnectedPortal", 1, 2)]
		private MTutorialPortal _ConnectedPortal;

		[SerializeField]
		private MTutorialHandler _portalHandler;

		private float _remainingTime;

		private static Changed<MTutorialPortal> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MTutorialPortal> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MTutorialPortal> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[NetworkedWeaved(0, 1)]
		[Networked]
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

		[NetworkedWeaved(1, 2)]
		[Networked]
		public MTutorialPortal ConnectedPortal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MTutorialHandler PortalHandler => null;

		public event Action<MTutorialPortal> OnPortalSpawned
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

		public event Action<MTutorialPortal, int> OnPortalUsed
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

		public event Action<MTutorialPortal> OnPortalDespawned
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

		public void ConnectToPortal(MTutorialPortal connectedPortal)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All, InvokeResim = true, Channel = RpcChannel.Reliable)]
		private void Rpc_ConnectToPortal(MTutorialPortal connectedPortal)
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
		protected unsafe static void Rpc_ConnectToPortal_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
