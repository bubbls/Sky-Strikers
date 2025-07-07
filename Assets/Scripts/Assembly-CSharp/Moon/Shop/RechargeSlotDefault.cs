using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using Chamber8.Framework.Service.PlayFab;
using DP.Takeaway.Inspector;
using DP.Takeaway.Utils;
using Moon.Economy;
using Moon.GameActivity;
using Moon.Hub;
using Moon.Shop.Charge;
using PlayFab.EconomyModels;
using UnityEngine;

namespace Moon.Shop
{
	public class RechargeSlotDefault : SaleSlotBase
	{
		[CompilerGenerated]
		private sealed class _003CInvokeCurrencyCallbackWithDelay_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CInvokeCurrencyCallbackWithDelay_003Ed__38(int _003C_003E1__state)
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

		[SerializeField]
		[PossibleStringValues(new string[] { "Slot Main" })]
		private string _slotName;

		[SerializeField]
		private ShopChargeManager _shopChargeManager;

		[SerializeField]
		private ManualToggle _infoButtonToggle;

		[SerializeField]
		private GameObjectToggle _rechargingInfoToggle;

		private SkuData? _skuData;

		private PlayerSlotObject? _slotObject;

		private IMessageSubscriber[]? _subscribers;

		private PlayerEconomy? _playerEconomy;

		private readonly Cooldown _cooldown;

		private bool _isPurchasing;

		public override SkuData? SkuData => null;

		public override bool IsValid => false;

		public bool IsInitialized { get; private set; }

		public bool IsPurchased => false;

		public void Initialize()
		{
		}

		public void UpdateSlot()
		{
		}

		private void UpdateState()
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

		private int HandleOnStoreOrInventoryChanged(IMessage<object> _)
		{
			return 0;
		}

		private void ChargeManager_RequestPurchaseCurrencies(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private void NotifyPurchased()
		{
		}

		public override int GetDisplayPrices(out Dictionary<PriceIndex, CatalogPriceAmount> displayPrices)
		{
			displayPrices = null;
			return 0;
		}

		private void SetupSkuData()
		{
		}

		private string? GetSkuId()
		{
			return null;
		}

		private SkuData LoadSkuData(CatalogItem storeItem, CatalogItem catalogItem)
		{
			return null;
		}

		private bool IsPurchasedInternal()
		{
			return false;
		}

		public override TimeSpan GetCountdown()
		{
			return default(TimeSpan);
		}

		private void Update()
		{
		}

		private void Refresh(Dictionary<string, object>? parameters = null)
		{
		}

		private bool ShouldRefresh()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CInvokeCurrencyCallbackWithDelay_003Ed__38))]
		private IEnumerator InvokeCurrencyCallbackWithDelay(Action<PlayerEconomyError> callback)
		{
			return null;
		}
	}
}
