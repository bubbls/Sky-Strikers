using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Chamber8.Framework.Common;
using Chamber8.Framework.Economy.API;
using Chamber8.Framework.Economy.Model;
using Chamber8.Framework.Messaging;
using Moon.Framework.Service.PlayFab.CloudScript;
using Moon.Framework.Service.PlayFab.PlayerInventory;
using PlayFab;
using PlayFab.EconomyModels;
using UnityEngine.Scripting;

namespace Chamber8.Framework.Service.PlayFab.PlayerInventory
{
	[Preserve]
	public class PlayFabPlayerInventoryService : IInitializer
	{
		private class RechargeResp<T> where T : notnull
		{
			public HttpStatusCode Code;

			public string Message;

			public T Data;

			public bool Success()
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public List<PlayFabPlayerInventoryItem> playerInventoryItems;

			public bool isDone;

			public GetInventoryItemsRequest request;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckTimeout_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public TaskCompletionSource<string> tcs;

			public TimeSpan timeSpan;

			public PurchaseResult purchaseResult;

			public PlayFabPlayerInventoryService _003C_003E4__this;

			public RechargeSourceType sourceType;

			private TaskAwaiter<string> _003C_003Eu__1;

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
		private struct _003CListInventory_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public string collectionId;

			public string filter;

			private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

			public PlayFabPlayerInventoryService _003C_003E4__this;

			public Action<Error> onError;

			public Action<List<PlayFabPlayerInventoryItem>> onSuccess;

			private TaskAwaiter<PlayFabError?> _003C_003Eu__1;

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

		private PlayFabCloudScriptInstanceAPI _cloudScriptInstanceAPI;

		private PlayFabCatalogItemService _catalogItemService;

		private const int PageSize = 50;

		private bool _isRechargeTimeout;

		public void Initialize()
		{
		}

		public void ListInventoryItemsAndCurrencies(Action<List<PlayFabPlayerInventoryItem>> onSuccess, Action<Error> onError)
		{
		}

		public void ListCurrencies(Action<List<PlayFabPlayerInventoryItem>> onSuccess, Action<Error> onError)
		{
		}

		public string GetItemFriendlyId(string itemId)
		{
			return null;
		}

		public CatalogItem GetRawItemFromFriendlyId(string itemFriendlyId)
		{
			return null;
		}

		private string GetItemIdFromFriendlyId(string friendlyId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CListInventory_003Ed__11))]
		public void ListInventory(string filter, string? collectionId, Action<List<PlayFabPlayerInventoryItem>>? onSuccess, Action<Error>? onError)
		{
		}

		public void ConsumeItem(List<ConsumeInventoryItemAmount> amount, Action<bool>? onSuccess, Action<CloudScriptResp<bool>>? onError)
		{
		}

		public void TransferInventoryItems(List<TransferInventoryItemsOperation> transferInventoryItemsOperations, Action? onSuccess, Action<string>? onError)
		{
		}

		public void ExchangeCurrency(string idempotencyId, string fromCurrencyCurrencyId, string toCurrencyCurrencyId, int amount, Action<ExchangeCurrencyResult> onComplete, Action<Error> onError)
		{
		}

		public void Recharge(List<PurchaseResult> purchaseResults, RechargeSourceType sourceType)
		{
		}

		public void RechargeByCouldScript(PurchaseResult purchaseResult, RechargeSourceType sourceType)
		{
		}

		[AsyncStateMachine(typeof(_003CCheckTimeout_003Ed__17))]
		private void CheckTimeout(PurchaseResult purchaseResult, RechargeSourceType sourceType, TaskCompletionSource<string> tcs, TimeSpan timeSpan)
		{
		}

		private void SendRechargeFailedMessage(PurchaseResult purchaseResult, RechargeSourceType sourceType)
		{
		}

		private void SendRechargeSuccessMessage(PurchaseResult purchaseResult, RechargeSourceType sourceType)
		{
		}

		private void SubscribeIapCheckoutMessage()
		{
		}

		private int OnIapCheckoutSucceeded(IMessage<PurchaseResult> message)
		{
			return 0;
		}
	}
}
