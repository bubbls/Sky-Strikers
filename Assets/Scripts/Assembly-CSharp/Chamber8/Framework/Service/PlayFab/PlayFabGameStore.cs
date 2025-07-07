using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.InGameStore;
using PlayFab;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab
{
	[Preserve]
	public class PlayFabGameStore
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabGameStore _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRefreshSlotAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabGameStore _003C_003E4__this;

			public Dictionary<string, object> parameters;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdatePlayerStoreDataAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public PlayFabGameStore _003C_003E4__this;

			public Dictionary<string, object> parameters;

			private CancellationTokenRegistration _003Cregistry_003E5__2;

			private object _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private TaskAwaiter<GetPlayerStoreDataResult> _003C_003Eu__1;

			private ValueTaskAwaiter _003C_003Eu__2;

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

		private PlayFabEconomyInstanceAPI _clientApi;

		private PlayFabCloudScriptInstanceAPI _cloudScriptApi;

		private GetPlayerStoreDataResult _playerStoreData;

		private bool _isRefreshing;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__2))]
		public Task InitializeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public void Purchase(IEnumerable<ItemOrder> orders, string idempotencyId, Action onSuccess, Action<Error> onError)
		{
		}

		public PlayerSlotObject GetSlot(string slotName)
		{
			return null;
		}

		public PlayerSlotObject GetSlot(string store, string slotName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRefreshSlotAsync_003Ed__8))]
		public Task RefreshSlotAsync(string slotName, Dictionary<string, object>? parameters = null)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdatePlayerStoreDataAsync_003Ed__9))]
		private Task UpdatePlayerStoreDataAsync(CancellationToken cancellationToken, Dictionary<string, object>? parameters = null)
		{
			return null;
		}
	}
}
