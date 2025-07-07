using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Service.Rpc;
using Fusion;
using UnityEngine.Scripting;

namespace Moon.Framework.Service.PhotonRpc
{
	[SimulationBehaviour(Stages = SimulationStages.Forward)]
	[NetworkBehaviourWeaved(0)]
	public class MPhotonRpcRunner : NetworkBehaviour
	{
		private static readonly byte[] _emptyBytes;

		private readonly List<Request> _pendingBroadcasts;

		private readonly List<Request> _pendingRequests;

		private readonly List<(PlayerRef playerRef, Response response)> _pendingResponses;

		private static Changed<MPhotonRpcRunner> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MPhotonRpcRunner> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MPhotonRpcRunner> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public event Action<Response> OnResponse
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

		public event Action<PlayerRef, Request> OnRequestFromClient
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

		public event Action<Request> OnBroadcastFromServer
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

		private void ProcessMessages()
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_Broadcast(string serviceName, string requestId, byte[] payload)
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void Rpc_Request(string serviceName, string requestId, byte[] payload, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_Response([RpcTarget] PlayerRef playerRef, string serviceName, string requestId, Result result, byte[] payload)
		{
		}

		public void Response(PlayerRef playerRef, Response response)
		{
		}

		public void Broadcast(Request request)
		{
		}

		public void Request(Request request)
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
		protected unsafe static void Rpc_Broadcast_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 7, 1)]
		[Preserve]
		protected unsafe static void Rpc_Request_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(3, 1, 7)]
		protected unsafe static void Rpc_Response_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
