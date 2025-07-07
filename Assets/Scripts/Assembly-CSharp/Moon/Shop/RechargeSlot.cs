using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DP.Takeaway.Inspector;
using Moon.Economy;
using Moon.GameActivity;
using Moon.Hub;
using Moon.Shop.Charge;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public class RechargeSlot : SaleSlotBase
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RechargeSlot _003C_003E4__this;

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
		private struct _003CInitializeExpireDateAsync_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RechargeSlot _003C_003E4__this;

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

		[CompilerGenerated]
		private sealed class _003CInvokeCurrencyCallbackWithDelay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopChargeProductData productData;

			public Action<PlayerEconomyError> callback;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInvokeCurrencyCallbackWithDelay_003Ed__41(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CInvokeRecoverCallbackWithDelay_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Action<PlayerEconomyError> callback;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInvokeRecoverCallbackWithDelay_003Ed__42(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSetExpireFromFirstSeenTheSlotAsync_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public RechargeSlot _003C_003E4__this;

			private TaskAwaiter<CheckStoreItemExpirationResult?> _003C_003Eu__1;

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

		private const string StoreFriendlyIdKey = "StoreFriendlyId";

		private const string ItemFriendlyIdKey = "ItemFriendlyId";

		[SerializeField]
		private ShopChargeManager _shopChargeManager;

		[PossibleStringValues(new string[] { "Slot1", "Slot2", "Slot3", "Slot4", "SlotMainStage" })]
		[SerializeField]
		private string _chargeSlot;

		[SerializeField]
		private ManualToggle _infoButtonToggle;

		[SerializeField]
		private GameObjectToggle _rechargingInfoToggle;

		private SkuData? _skuData;

		private PlayerEconomy? _playerEconomy;

		private bool _isPurchasing;

		private DateTime _expireDate;

		private readonly Dictionary<PriceIndex, CatalogPriceAmount> _priceIndexPrices;

		public override SkuData? SkuData => null;

		public override bool IsValid => false;

		public bool IsInitialized { get; private set; }

		public bool IsPurchased => false;

		public bool IsExpired => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__25))]
		public Task InitializeAsync()
		{
			return null;
		}

		private void UpdateStatus()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleInfoButtonValueChanged()
		{
		}

		private bool IsPurchasedInternal()
		{
			return false;
		}

		private bool IsExpiredInternal()
		{
			return false;
		}

		private void ChargeManager_RequestPurchaseCurrencies(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private void ChargeManager_RequestRecoverPurchasingCurrencies(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private void NotifyPurchased()
		{
		}

		private void InitializeSkuData()
		{
		}

		public override int GetDisplayPrices(out Dictionary<PriceIndex, CatalogPriceAmount> displayPrices)
		{
			displayPrices = null;
			return 0;
		}

		public override TimeSpan GetCountdown()
		{
			return default(TimeSpan);
		}

		[AsyncStateMachine(typeof(_003CInitializeExpireDateAsync_003Ed__38))]
		private Task InitializeExpireDateAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CSetExpireFromFirstSeenTheSlotAsync_003Ed__39))]
		private Task SetExpireFromFirstSeenTheSlotAsync()
		{
			return null;
		}

		private SkuData LoadSkuData(CatalogItem store, CatalogItem catalogItem)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInvokeCurrencyCallbackWithDelay_003Ed__41))]
		private IEnumerator InvokeCurrencyCallbackWithDelay(ShopChargeProductData productData, Action<PlayerEconomyError> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInvokeRecoverCallbackWithDelay_003Ed__42))]
		private IEnumerator InvokeRecoverCallbackWithDelay(ShopChargeProductData productData, Action<PlayerEconomyError> callback)
		{
			return null;
		}
	}
}
