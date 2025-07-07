using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.EconomyModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab.PlayerInventory
{
	[Preserve]
	public class PlayFabCatalogItemService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCacheItemsAsync_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabCatalogItemService _003C_003E4__this;

			public CancellationToken cancellationToken;

			private bool _003CisDone_003E5__2;

			private string _003CcontinuationToken_003E5__3;

			private CancellationTokenRegistration _003Cregistry_003E5__4;

			private object _003C_003E7__wrap4;

			private int _003C_003E7__wrap5;

			private TaskAwaiter<string> _003C_003Eu__1;

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
		private struct _003CInitializeAsync_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayFabCatalogItemService _003C_003E4__this;

			public PlayFabAuthenticationContext context;

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

		private const int PageSize = 50;

		public const string TypeBundle = "bundle";

		public const string TypeStore = "store";

		public const string TypeCatalogItem = "catalogItem";

		public const string TypeCurrency = "currency";

		private PlayFabEconomyInstanceAPI _economyApi;

		private readonly Dictionary<string, CatalogItem> _items;

		private readonly List<CatalogItem> _allItems;

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__8))]
		public Task InitializeAsync(PlayFabAuthenticationContext context, CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CCacheItemsAsync_003Ed__9))]
		private Task CacheItemsAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public string FriendlyIdToItemId(string itemFriendlyId)
		{
			return null;
		}

		public string ItemIdToFriendlyId(string itemId)
		{
			return null;
		}

		public CatalogItem? GetItem(string? itemIdOrFriendlyId)
		{
			return null;
		}

		public IEnumerable<CatalogItem> AllItems()
		{
			return null;
		}
	}
}
