using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DP.Takeaway.Utils;
using Fusion;
using UnityEngine;
using UnityEngine.Scripting;

namespace Moon.GameActivity
{
	[NetworkBehaviourWeaved(0)]
	public class MSipletsCollector : NetworkBehaviour, ICommandExecutor
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CTryPutSipletsToInventoryAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public SipletsTrail trail;

			public MSipletsCollector _003C_003E4__this;

			private string _003CplayFabId_003E5__2;

			private string _003CidempotencyIdString_003E5__3;

			private string _003Cid_003E5__4;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[SerializeField]
		private SipletsCollectorVisual _visual;

		private static Changed<MSipletsCollector> _0024IL2CPP_CHANGED;

		private static ChangedDelegate<MSipletsCollector> _0024IL2CPP_CHANGED_DELEGATE;

		private static NetworkBehaviourCallbacks<MSipletsCollector> _0024IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

		public override void Spawned()
		{
		}

		[AsyncStateMachine(typeof(_003CTryPutSipletsToInventoryAsync_003Ed__2))]
		private void TryPutSipletsToInventoryAsync(SipletsTrail trail)
		{
		}

		public void AddSiplets(SipletsTrail trail)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_WillCollect(NetworkString<_32> idempotencyId, SipletsTrail trail)
		{
		}

		[Rpc(RpcSources.StateAuthority, RpcTargets.All)]
		private void Rpc_ConfirmCollection(NetworkString<_32> idempotencyId, NetworkBool success, int amount)
		{
		}

		public ICommand ExecuteCommand(ICommand command)
		{
			return null;
		}

		public override void CopyBackingFieldsToState(bool P_0)
		{
		}

		public override void CopyStateToBackingFields()
		{
		}

		[NetworkRpcWeavedInvoker(1, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_WillCollect_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}

		[NetworkRpcWeavedInvoker(2, 1, 7)]
		[Preserve]
		protected unsafe static void Rpc_ConfirmCollection_0040Invoker(NetworkBehaviour behaviour, SimulationMessage* message)
		{
		}
	}
}
