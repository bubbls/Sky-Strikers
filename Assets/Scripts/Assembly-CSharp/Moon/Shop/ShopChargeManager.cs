using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Chamber8.Framework.Messaging;
using DG.Tweening;
using DP.Takeaway.Utils;
using Moon.Economy;
using Moon.Shop.Charge;
using UnityEngine;

namespace Moon.Shop
{
	public class ShopChargeManager : InPlaceList<ShopChargeManager>
	{
		[CompilerGenerated]
		private sealed class _003CHandleOnApplicationFocusCoroutine_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopChargeManager _003C_003E4__this;

			private float _003CcurrentCountdown_003E5__2;

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
			public _003CHandleOnApplicationFocusCoroutine_003Ed__48(int _003C_003E1__state)
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
		private ShopChargeAtmController _atmController;

		[SerializeField]
		private ShopChargeScreenController _screenController;

		[SerializeField]
		private ShopChargeProductDataDefinitionManager _definitionManager;

		[SerializeField]
		private ShopChargeProductDataDefinitionManager _definitionManagerSteam;

		[SerializeField]
		private List<ShopChargeProduct> _chargeProductList;

		private readonly HashSet<IMessageSubscriber> _subscribers;

		private PlayerEconomy _playerEconomy;

		private string _currentChargeProductSlot;

		private string _currentChargeProductIgcAmount;

		private bool _isProcessingCharge;

		private Sequence _sequence;

		private Tween _effectMovingTween;

		private bool _isIapChargeSucceed;

		private bool _isBalanceUpdated;

		private bool _hasReceivedCallback;

		private Coroutine _focusCoroutine;

		private const float CountdownTime = 10f;

		private bool _isReconnect;

		private bool _isInitialized;

		private ShopChargeProductDataDefinitionManager DefinitionManager => null;

		public event Action<ShopChargeProductData, Action<PlayerEconomyError>> RequestPurchaseCurrencies
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

		public event Action<ShopChargeProductData, Action<PlayerEconomyError>> RequestRecoverPurchasingCurrencies
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

		public event Action OnPurchaseCompleted
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

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void TrySetReconnectStatus()
		{
		}

		private void StopFocusCoroutine()
		{
		}

		private void SetupProducts()
		{
		}

		private int HandleOnCurrencyProductsUpdated(IMessage<object> _)
		{
			return 0;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SyncProductData()
		{
		}

		private void HandleRequestPurchase(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private static void ResetProductsStatus()
		{
		}

		private void ResetProductsStatusInternal()
		{
		}

		private int HandleOnPlayerBalanceChanged(IMessage<object> message)
		{
			return 0;
		}

		private void HandleRequestRecoverPurchasingCurrencies(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private static void DisableAllProductsExcept(ShopChargeProductData productData)
		{
		}

		private void TryCompleteRecharge()
		{
		}

		private void HandleOnInputFocusChanged(bool hasFocus)
		{
		}

		private int HandleOnGeneralGameOverlay(IMessage<object> message)
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CHandleOnApplicationFocusCoroutine_003Ed__48))]
		private IEnumerator HandleOnApplicationFocusCoroutine()
		{
			return null;
		}

		public void SetProductsPurchased()
		{
		}
	}
}
