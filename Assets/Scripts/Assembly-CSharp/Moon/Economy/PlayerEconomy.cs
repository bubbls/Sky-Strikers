using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Chamber8.Framework.Economy.IAP;
using Chamber8.Framework.Economy.Model;
using Chamber8.Framework.InGameStore;
using Chamber8.Framework.Messaging;
using Chamber8.Framework.Service.PlayFab;
using Chamber8.Framework.Service.PlayFab.PlayerInventory;
using Moon.Framework.Service.PlayFab.PlayerInventory;
using Moon.Shop;
using PlayFab.EconomyModels;
using UnityEngine.Scripting;

namespace Moon.Economy
{
	[Preserve]
	public class PlayerEconomy
	{
		private class PlayFabSku
		{
			public readonly CatalogItem Item;

			public readonly CatalogItemReference ItemReference;

			public PlayFabSku(CatalogItem item, CatalogItemReference itemReference)
			{
			}
		}

		public enum CurrencyProductStatus
		{
			CanPurchase = 0,
			IapReceiptNotConsumedYet = 1,
			NotAvailable = 2
		}

		private enum UpdatePlayerInventoryResult
		{
			Unchanged = 0,
			Changed = 1,
			Error = 2
		}

		private enum RechargeResult
		{
			Success = 0,
			CheckoutFailed = 1,
			RechargeFailed = 2,
			IapReceiptConsumeFailed = 3
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CFlushPendingTransferAsync_003Ed__122 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

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
		private struct _003CInitializeAsync_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

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
		private struct _003CInitializeAsyncInternal_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

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
		private struct _003CRefreshStoreSlotAsync_003Ed__114 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			public string slotName;

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
		private struct _003CStartPollingPlayerCurrencies_003Ed__95 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			public bool lookingForChanged;

			private int _003Ccount_003E5__2;

			private bool _003Cchanged_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<UpdatePlayerInventoryResult> _003C_003Eu__2;

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
		private struct _003CStartPollingPlayerItemsAndCurrencies_003Ed__93 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			public bool lookingForChanged;

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
		private struct _003CStartPollingPlayerItemsAndCurrenciesAsync_003Ed__94 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			public bool lookingForChanged;

			private int _003Ccount_003E5__2;

			private bool _003Cchanged_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private TaskAwaiter<UpdatePlayerInventoryResult> _003C_003Eu__2;

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
		private struct _003CTryAddPurchasedOculusDlcToInventoryItem_003Ed__88 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			public List<PlayFabPlayerInventoryItem> list;

			private List<PlayFabPlayerInventoryItem> _003CpurchasedItems_003E5__2;

			private TaskAwaiter<int> _003C_003Eu__1;

			private List<string> _003CoculusDlcIdsToAdd_003E5__3;

			private TaskAwaiter<PlayerWebStoreService.AddPurchasedItemsFromWebStoreResponseData> _003C_003Eu__2;

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
		private struct _003CUpdateCurrencyProducts_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			private TaskAwaiter<int[]> _003C_003Eu__1;

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
		private struct _003CUpdatePlayerItemsAndCurrenciesAsync_003Ed__65 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<UpdatePlayerInventoryResult> _003C_003Et__builder;

			public PlayerEconomy _003C_003E4__this;

			private TaskAwaiter<UpdatePlayerInventoryResult> _003C_003Eu__1;

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

		private static readonly string[] _builtInItemFriendlyIds;

		private readonly List<PurchaseResult> _currencyProductPurchaseResults;

		private CatalogItem? _juiceStoreItem;

		private CatalogItem? _gameStoreItem;

		private CatalogItem? _activityStoreItem;

		private CatalogItem? _freeCurrencyStoreItem;

		private readonly HashSet<string> _allStoreProducts;

		private readonly List<PlayFabSku> _currencyBundleProducts;

		private readonly HashSet<string> _purchasedSkus;

		public readonly HashSet<string> PurchasedSkuFriendlyIds;

		private const int InventoryPollingCount = 5;

		private const int InventoryPollingInterval = 5000;

		private bool _isPollingCurrencies;

		private bool _isPollingItemsAndCurrencies;

		private const string DurableKey = "durable";

		private IIapService? _iapService;

		private PlayFabPlayerInventoryService _inventoryService;

		private PlayFabGameStore _gameStore;

		private PlayFabCatalogItemService _catalogItemService;

		private PlayerWebStoreService _webStoreService;

		private PlayFabPlayerInventoryItem? _currencyJuiceItem;

		private PlayFabPlayerInventoryItem? _currencySipletsItem;

		private PlayFabPlayerInventoryItem? _currencyDataItem;

		private PlayFabPlayerInventoryItem? _currencyFreeCurrencyItem;

		private PlayFabPlayerInventoryItem? _modsPFlag;

		private readonly IdempotencyIdPlacement _gameStorePurchaseIdPlacement;

		private readonly IdempotencyIdPlacement _inventoryIdempotencyIdPlacement;

		private TaskCompletionSource<RechargeResult>? _purchasingCurrencyTask;

		private bool _initialized;

		private readonly List<TransferInventoryItemsOperation> _transferInventoryItemsOperations;

		public int JuiceBalance => 0;

		public int SipletsBalance => 0;

		public int DataBalance => 0;

		public int FreeCurrencyBalance => 0;

		public List<Product> CurrencyProducts { get; }

		public CatalogItem? GameStoreItem => null;

		public List<PlayFabPlayerInventoryItem> PlayerInventoryItems { get; }

		public bool HasPFlag => false;

		public bool PlayerInventoryUpdated { get; private set; }

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__55))]
		public Task InitializeAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CInitializeAsyncInternal_003Ed__56))]
		private Task InitializeAsyncInternal(CancellationToken cancellationToken)
		{
			return null;
		}

		private void UpdateStoresAsync()
		{
		}

		private void GetItemReferencesString(StringBuilder sb, string prefix, CatalogItem catalogItem)
		{
		}

		private static void AddStoreProducts(CatalogItem? storeItem, HashSet<string> allStoreProducts)
		{
		}

		private void UpdatePurchasedItems()
		{
		}

		[AsyncStateMachine(typeof(_003CUpdateCurrencyProducts_003Ed__61))]
		private void UpdateCurrencyProducts()
		{
		}

		private void ComposingFakeCurrencyProducts()
		{
		}

		private List<Product> MapByPlayFabStoreSettings(List<Product> products)
		{
			return null;
		}

		private List<PurchaseResult> ReplacePlatformSkuIdWithFriendlyId(List<PurchaseResult> purchaseResults)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUpdatePlayerItemsAndCurrenciesAsync_003Ed__65))]
		private Task<UpdatePlayerInventoryResult> UpdatePlayerItemsAndCurrenciesAsync()
		{
			return null;
		}

		private void UpdatePlayerCurrencies(TaskCompletionSource<UpdatePlayerInventoryResult> taskCompletionSource)
		{
		}

		public string GetFriendlyId(PlayFabPlayerInventoryItem item)
		{
			return null;
		}

		public CatalogItem? GetItem(string? itemIdOrFriendlyId)
		{
			return null;
		}

		private bool UpdateCurrency(IEnumerable<PlayFabPlayerInventoryItem> list, string currencyFriendlyId, ref PlayFabPlayerInventoryItem? currencyItem)
		{
			return false;
		}

		public bool IsPurchased(SkuData skuData)
		{
			return false;
		}

		public bool IsBundlePurchased(SkuData skuData)
		{
			return false;
		}

		private bool IsPurchasedInternal(HashSet<string> purchasedSkus, SkuData skuData)
		{
			return false;
		}

		public void Purchase3(List<ItemOrderRequest> itemOrdersRequests, string orderSource, Action<PlayerEconomyError>? onComplete)
		{
		}

		private bool TryCreateItemOrderFromRequest(ItemOrderRequest itemOrderRequest, out ItemOrder? itemOrder)
		{
			itemOrder = null;
			return false;
		}

		private int HandlePlayerInventoryRechargeSucceeded(IMessage<RechargeMessagePayload> message)
		{
			return 0;
		}

		private int HandlePlayerIapConsumeFailed(IMessage<RechargeMessagePayload> message)
		{
			return 0;
		}

		private int HandleIapCheckoutFailed(IMessage<PurchaseError> message)
		{
			return 0;
		}

		private int HandlePlayerInventoryRechargeFailed(IMessage<RechargeMessagePayload> message)
		{
			return 0;
		}

		public CurrencyProductStatus GetCurrencyProductStatus(string sku)
		{
			return default(CurrencyProductStatus);
		}

		public void TryRecoverPurchasingWithCurrency(string skuId, Action<PlayerEconomyError>? onComplete)
		{
		}

		public void TryRecoverPurchasingCurrencies(string slot, Action<PlayerEconomyError>? onComplete)
		{
		}

		private void RecoverPurchasingInternal(string skuId, Action<PlayerEconomyError>? onComplete)
		{
		}

		public void PurchaseWithCurrency(string skuId, Action<PlayerEconomyError>? onComplete)
		{
		}

		public void PurchaseCurrencies(string slot, Action<PlayerEconomyError>? onComplete)
		{
		}

		private void PurchaseInternal(string skuId, Action<PlayerEconomyError>? onComplete)
		{
		}

		private string ConvertSkuId(string skuId)
		{
			return null;
		}

		private void AddBuiltInItemsToInventory(List<PlayFabPlayerInventoryItem> list)
		{
		}

		[AsyncStateMachine(typeof(_003CTryAddPurchasedOculusDlcToInventoryItem_003Ed__88))]
		private void TryAddPurchasedOculusDlcToInventoryItem(List<PlayFabPlayerInventoryItem> list)
		{
		}

		private SkuData LoadSkuData(CatalogItem storeItem, CatalogItem catalogItem)
		{
			return null;
		}

		private void AddSteamDlcToInventoryItem(List<PlayFabPlayerInventoryItem> list)
		{
		}

		private void AddAdditionalItemsToInventory(List<PlayFabPlayerInventoryItem> list)
		{
		}

		private bool IsPlayerInventoryChanged(IReadOnlyCollection<PlayFabPlayerInventoryItem> newList)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CStartPollingPlayerItemsAndCurrencies_003Ed__93))]
		public void StartPollingPlayerItemsAndCurrencies(bool lookingForChanged = false)
		{
		}

		[AsyncStateMachine(typeof(_003CStartPollingPlayerItemsAndCurrenciesAsync_003Ed__94))]
		private Task StartPollingPlayerItemsAndCurrenciesAsync(bool lookingForChanged)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStartPollingPlayerCurrencies_003Ed__95))]
		public void StartPollingPlayerCurrencies(bool lookingForChanged = false)
		{
		}

		public void ExchangeCurrency(string fromCurrencyFriendlyId, string toCurrencyFriendlyId, int amount, Action<PlayerEconomyError, ExchangeCurrencyResult>? complete)
		{
		}

		private void LogPayButtonClick(string skuId)
		{
		}

		private void LogPaySucceeded(PurchaseResult purchaseResult)
		{
		}

		private static void LogPayFailed(PurchaseError purchaseError, RechargeResult result)
		{
		}

		private void LogShopGoodsBuy(List<ItemOrder> itemOrders, string orderSource)
		{
		}

		private void LogShopGoodsBuySucceeded(List<ItemOrder> itemOrders, string orderSource)
		{
		}

		private void LogShopGoodsBuyFailed(List<ItemOrder> itemOrders, string error, string orderSource)
		{
		}

		private string GetItemIdOrDefault(string friendlyId)
		{
			return null;
		}

		public void NotifyItemConsumed(string friendlyId, string stackId)
		{
		}

		private void NotifyItemPurchased(IEnumerable<ItemOrder> list)
		{
		}

		private void NotifyItemPurchased(CatalogItem item, int amount)
		{
		}

		public void NotifyItemPurchasedAndUpdatePurchasedItems(List<CatalogItem> items)
		{
		}

		public void NotifyItemPurchasedAndUpdatePurchasedItems(CatalogItem item, int amount)
		{
		}

		public void NotifyItemAdded(string friendlyId, string stackId, int amount, bool sendMessage = true)
		{
		}

		public void NotifyCurrencyAdded(string currencyFriendlyId, int amount)
		{
		}

		private void EnsureCurrency(string currencyFriendlyId, Action<PlayFabPlayerInventoryItem> action)
		{
		}

		public PlayerSlotObject GetStoreSlot(string slotName)
		{
			return null;
		}

		public PlayerSlotObject GetStoreSlot(string store, string slotName)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CRefreshStoreSlotAsync_003Ed__114))]
		public void RefreshStoreSlotAsync(string slotName, Dictionary<string, object>? parameters)
		{
		}

		public int GetBalance(string currencyItemIdOrFriendlyId)
		{
			return 0;
		}

		public void AddTransferOperation(string friendlyId, string givingStackId, string receivingStackId, int amount)
		{
		}

		public void SwapStackOfItems(string fromFriendlyId, string fromStackId, int fromAmount, string toFriendlyId, string toStackId, int toAmount)
		{
		}

		private static TransferInventoryItemsOperation GenerateTransferOperation(string friendlyId, string givingStackId, string receivingStackId, int amount)
		{
			return null;
		}

		private void AddOrMergeOperation(TransferInventoryItemsOperation operation)
		{
		}

		private void TransferItemsLocally(string friendlyId, string fromStackId, string toStackId, int amount)
		{
		}

		[AsyncStateMachine(typeof(_003CFlushPendingTransferAsync_003Ed__122))]
		public Task FlushPendingTransferAsync()
		{
			return null;
		}

		private void SwapStackOfItemsLocally(string fromFriendlyId, string fromStackId, string toFriendlyId, string toStackId)
		{
		}

		public PlayFabPlayerInventoryItem FirstItemAtStackIdOrDefault(string stackId)
		{
			return null;
		}
	}
}
