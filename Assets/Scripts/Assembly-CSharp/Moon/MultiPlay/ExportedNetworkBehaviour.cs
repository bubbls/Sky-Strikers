using System;
using System.Runtime.CompilerServices;
using Fusion;
using JetBrains.Annotations;
using UnityEngine.Scripting;

namespace Moon.MultiPlay
{
	[NetworkBehaviourWeaved(0)]
	public class ExportedNetworkBehaviour : NetworkBehaviour
	{
		private static Changed<ExportedNetworkBehaviour> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<ExportedNetworkBehaviour> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<ExportedNetworkBehaviour> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public event Action OnSpawned
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

		public event Action<NetworkRunner, bool> OnDespawned
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

		[UsedImplicitly]
		public void RPC_Publish(string eventName, string parameter)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void RPC_PublishInternal(string eventName, string parameter, RpcInfo info = default(RpcInfo))
		{
		}

		[UsedImplicitly]
		public void RPC_Request(string eventName, string parameter)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void RPC_RequestInternal(string eventName, string parameter, RpcInfo info = default(RpcInfo))
		{
		}

		public override void Spawned()
		{
		}

		public override void Despawned(NetworkRunner runner, bool hasState)
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
		protected unsafe static void RPC_PublishInternal_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 7, 1)]
		protected unsafe static void RPC_RequestInternal_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
