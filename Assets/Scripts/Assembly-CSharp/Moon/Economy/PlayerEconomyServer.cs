using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using UnityEngine.Scripting;

namespace Moon.Economy
{
	[Preserve]
	public class PlayerEconomyServer
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddFreeCurrencyAsync_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PlayerEconomyServer _003C_003E4__this;

			public string playFabId;

			public int amount;

			public string idempotencyId;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddSipletsAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public PlayerEconomyServer _003C_003E4__this;

			public string playFabId;

			public int amount;

			public string idempotencyId;

			private TaskAwaiter<bool> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayerEconomyServer _003C_003E4__this;

			public CancellationToken cancellationToken;

			private TaskAwaiter _003C_003Eu__1;

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

		private PlayFabPlayerInventoryServerService _inventoryServer;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__1))]
		public Task InitializeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddSipletsAsync_003Ed__2))]
		public Task<bool> AddSipletsAsync(string playFabId, int amount, string idempotencyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddFreeCurrencyAsync_003Ed__3))]
		public Task<bool> AddFreeCurrencyAsync(string playFabId, int amount, string idempotencyId)
		{
			return null;
		}
	}
}
