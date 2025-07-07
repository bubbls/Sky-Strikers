using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.EconomyModels;
using PlayFab.ServerModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab.PlayerInventory
{
	[Preserve]
	public class PlayFabPlayerInventoryServerService
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public TaskCompletionSource<bool> tcs;

			public string idempotencyId;

			internal void _003CAddCurrencyAsync_003Eb__0()
			{
			}

			internal void _003CAddCurrencyAsync_003Eb__1(AddInventoryItemsResponse result)
			{
			}

			internal void _003CAddCurrencyAsync_003Eb__2(PlayFabError error)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddCurrencyAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public string idempotencyId;

			public PlayFabPlayerInventoryServerService _003C_003E4__this;

			public string currencyFriendlyId;

			public string playFabId;

			public int amount;

			private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

			private string _003CcurrencyItemId_003E5__2;

			private CancellationTokenRegistration _003Cregistry_003E5__3;

			private TaskAwaiter<UserAccountInfo> _003C_003Eu__1;

			private object _003C_003E7__wrap3;

			private int _003C_003E7__wrap4;

			private bool _003C_003E7__wrap5;

			private TaskAwaiter<bool> _003C_003Eu__2;

			private ValueTaskAwaiter _003C_003Eu__3;

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
		private struct _003CGetUserAccountInfoAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UserAccountInfo> _003C_003Et__builder;

			public PlayFabPlayerInventoryServerService _003C_003E4__this;

			public string playFabId;

			private UserAccountInfo _003CuserAccountInfo_003E5__2;

			private CancellationTokenRegistration _003Cregistry_003E5__3;

			private object _003C_003E7__wrap3;

			private int _003C_003E7__wrap4;

			private TaskAwaiter<UserAccountInfo> _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabPlayerInventoryServerService _003C_003E4__this;

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

		private PlayFabEconomyInstanceAPI _economyApi;

		private PlayFabServerInstanceAPI _serverApi;

		private PlayFabCatalogItemService _inventoryService;

		private readonly Dictionary<string, UserAccountInfo> _cachedUserAccountInfos;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__4))]
		public Task InitializeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CGetUserAccountInfoAsync_003Ed__5))]
		private Task<UserAccountInfo> GetUserAccountInfoAsync(string playFabId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CAddCurrencyAsync_003Ed__6))]
		public Task<bool> AddCurrencyAsync(string playFabId, string currencyFriendlyId, int amount, string idempotencyId)
		{
			return null;
		}
	}
}
