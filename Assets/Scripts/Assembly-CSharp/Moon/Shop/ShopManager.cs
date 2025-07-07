using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Moon.Economy;
using Moon.Shop.Charge;
using UnityEngine;

namespace Moon.Shop
{
	[Obsolete]
	public class ShopManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInvokeCurrencyCallbackWithDelay_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CInvokeCurrencyCallbackWithDelay_003Ed__7(int _003C_003E1__state)
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
		private sealed class _003CInvokeRecoverCallbackWithDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
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
			public _003CInvokeRecoverCallbackWithDelay_003Ed__8(int _003C_003E1__state)
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
		private ShopChargeManager _chargeManager;

		private PlayerEconomy _playerEconomy;

		private void Start()
		{
		}

		private void Initialize()
		{
		}

		private void ChargeManager_RequestPurchaseCurrencies(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private void ChargeManager_RequestRecoverPurchasingCurrencies(ShopChargeProductData productData, Action<PlayerEconomyError> onComplete)
		{
		}

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeCurrencyCallbackWithDelay_003Ed__7))]
		private IEnumerator InvokeCurrencyCallbackWithDelay(ShopChargeProductData productData, Action<PlayerEconomyError> callback)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInvokeRecoverCallbackWithDelay_003Ed__8))]
		private IEnumerator InvokeRecoverCallbackWithDelay(ShopChargeProductData productData, Action<PlayerEconomyError> callback)
		{
			return null;
		}
	}
}
