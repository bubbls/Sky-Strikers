using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Moon.Shop.Sale
{
	public class ShopProductPurchaseEquipButtonVisual : ShopProductEquipButtonVisual
	{
		[CompilerGenerated]
		private sealed class _003CProcessPurchasing_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ShopProductPurchaseEquipButtonVisual _003C_003E4__this;

			private string[] _003Cdots_003E5__2;

			private float _003Cinterval_003E5__3;

			private int _003Cindex_003E5__4;

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
			public _003CProcessPurchasing_003Ed__10(int _003C_003E1__state)
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
		private ShopSaleProductEquipButtonConfig _defaultStateConfig;

		[SerializeField]
		private ShopSaleProductEquipButtonConfig _confirmStateConfig;

		[SerializeField]
		private ShopSaleProductEquipButtonConfig _purchasingStateConfig;

		[SerializeField]
		[Space(10f)]
		private GameObject _priceVisualContainer;

		[SerializeField]
		private GameObject _messageVisualContainer;

		[SerializeField]
		private TMP_Text _priceText;

		[SerializeField]
		private TMP_Text _priceBackgroundText;

		private Coroutine _coroutine;

		private bool _isPurchasing;

		private void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CProcessPurchasing_003Ed__10))]
		private IEnumerator ProcessPurchasing()
		{
			return null;
		}

		public void ShowDefaultState(string price)
		{
		}

		public void ShowConfirmState()
		{
		}

		public void ShowPurchasingState()
		{
		}

		public void TogglePriceVisuals(bool enable)
		{
		}

		public void StopPurchasingCoroutine()
		{
		}

		public void ShowDisabledState()
		{
		}
	}
}
