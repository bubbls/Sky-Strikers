using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.AI.VisualScripting
{
	[NetworkBehaviourWeaved(1)]
	public class MStateMachineDriver : NetworkBehaviour, IAfterUpdate
	{
		private struct Message
		{
			public readonly GameObject Target;

			public readonly int MessageId;

			public Message(GameObject target, int messageId)
			{
				Target = null;
				MessageId = 0;
			}
		}

		private const string EventStateAuthorityUpdate = "StateAuthorityUpdate";

		private const string EventPlayerUpdate = "PlayerUpdate";

		private const string EventRenderPlayer = "RenderPlayer";

		private const string EventOnNetMsgReceived = "OnNetMsgReceived";

		[DefaultForProperty("State", 0, 1)]
		private int _State;

		private readonly List<Message> _messageReceivedFromStateAuthority;

		private readonly List<Message> _messageReceivedFromInputAuthority;

		private readonly List<INetworkTask> _tasks;

		private static Changed<MStateMachineDriver> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MStateMachineDriver> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MStateMachineDriver> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		[Networked(OnChanged = "HandleStateChanged")]
		[NetworkedWeaved(0, 1)]
		private int State
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public event Action<int> OnStateChanged
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

		public event Action<NetworkObject, byte[], RpcInfo, RpcSources> OnMessageReceived
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

		public void RegisterTask(INetworkTask task)
		{
		}

		public void UnregisterTask(INetworkTask task)
		{
		}

		public override void Spawned()
		{
		}

		public override void FixedUpdateNetwork()
		{
		}

		public override void Render()
		{
		}

		private void FireNetMessages()
		{
		}

		[Rpc(RpcSources.All, RpcTargets.StateAuthority)]
		private void Rpc_ClientReport(byte[] data, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_ServerBroadcast(byte[] data, RpcInfo rpcInfo = default(RpcInfo))
		{
		}

		public void RaiseMessageReceived(GameObject target, int messageId, RpcSources rpcSources)
		{
		}

		public void ServerBroadcast(byte[] data)
		{
		}

		public void ClientReport(byte[] data)
		{
		}

		[Preserve]
		public void SetState(int state)
		{
		}

		[Preserve]
		private static void HandleStateChanged(Changed<MStateMachineDriver> changed)
		{
		}

		private void NotifyStateChanged()
		{
		}

		public void AfterUpdate()
		{
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(1, 7, 1)]
		protected unsafe static void Rpc_ClientReport_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[Preserve]
		[NetworkRpcWeavedInvoker(2, 1, 7)]
		protected unsafe static void Rpc_ServerBroadcast_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
